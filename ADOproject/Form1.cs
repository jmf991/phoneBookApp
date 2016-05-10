using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

using System.Diagnostics;//para Debug.Assert

namespace ADOproject
{
    public partial class Form1 : Form
    {
        string datosConexion = "Data Source=net-2;Initial Catalog=listaTelefonos;Integrated Security=true;";//cadena conexion
        SqlConnection conn = new SqlConnection();//conexion
        SqlDataAdapter dataadapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        //CARGAR LISTADO
        private void button_cargarListado_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = datosConexion;
                conn.Open();//abre conexion

                string sql = "SELECT * FROM telefonosTable4"; //selecciona todos los datos de telefonosTable4
                SqlConnection connection = new SqlConnection(datosConexion);//inicializa los datos de la conexion
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);//inicializa el adapter de la conexion
                DataSet ds = new DataSet();//inicializa el dataset 
                //Si no se incluye este dataset aqui, se mostrara un nuevo ds (sucesivamente) cada vez que se clique el boton

                dataadapter.Fill(ds, "phoneBookList_table");//rellena el dataset 
                datagridView1.AllowUserToAddRows = false;//eliminamos la ultima fila del datagridview que se autoagrega  
                connection.Close();//cierra conexion
                datagridView1.DataSource = ds;//aplica al datagridView el dataset como su dataSource
                datagridView1.DataMember = "phoneBookList_table";

                rowsCounter(); //metodo para contar el total de rows mostradas
                hider(); //metodo para ocultar las filas borradas (con valor 0 en la columna de estaActivo)
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("Error de Carga");
                return;
            }
        }
        // END CARGAR LISTADO

        //INSERTAR ROW EN DB
        private void button_insert_Click(object sender, EventArgs e)
        {   // se especifican los campos y valores a insertar
            string cmdString = "INSERT INTO telefonosTable4 (fName,lName,phone, IdPhoneBook, InternalId, estaActivo) VALUES (@val1, @val2, @val3, @val4, @val5, @val6)";
            using (SqlConnection conn = new SqlConnection(datosConexion))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = cmdString;
                    comm.Parameters.AddWithValue("@val1", textBox_fName.Text);//valor a insertar para fName
                    comm.Parameters.AddWithValue("@val2", textBox_lName.Text);//valor a insertar para lName
                    comm.Parameters.AddWithValue("@val3", textBox_phone.Text);//valor a insertar para phone
                    comm.Parameters.AddWithValue("@val4", textBox_IdPhoneBook.Text);//valor a insertar para IdPhoneBook
                    comm.Parameters.AddWithValue("@val5", textBox_InternalId.Text);//valor a insertar para InternalId
                    comm.Parameters.AddWithValue("@val6", 1);//valor a insertar para estaActivo (Por defecto 1, para que se muestre)

                    try
                    {
                        conn.Open();//se abre conexion
                        comm.ExecuteNonQuery();//se ejecuta comando
                        MessageBox.Show("datos insertados en la base de datos");
                        conn.Close();//se cierra conexion
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error: es posible que los datos no estén en el formato correcto");
                        return;
                    }
                }
            }
        }
        // END INSERTAR ROW EN DB

        //BORRAR ROW EN DB
        private void button_delete_Click(object sender, EventArgs e)
        {
            if (datagridView1.SelectedRows.Count > 0) //se debe haber seleccionado al menos una fila a borrar, si no saltará un error
            {
                int selectedRow = this.datagridView1.SelectedRows[0].Index; //Para localizar la fila a borrar

                if (this.datagridView1.Rows[selectedRow].Cells["InternalId"].Value != null) //Si el valor del del InternalId no es null
                {
                    System.Text.StringBuilder InternalId = new System.Text.StringBuilder(); //Muestra valor de InternalId de la fila seleccionada

                    InternalId.Append(datagridView1.Rows[selectedRow].Cells["InternalId"].Value.ToString());
                    MessageBox.Show("El InternalId de la fila a borrar es: " + InternalId);

                    //Si la fila está vacia el valor del InternalId será incorrecto (espacio en blanco)
                    int i = 0;
                    for (i = 0; i >= InternalId.Length; ) //si el la columa de InternalId esta vacia:
                    {
                        MessageBox.Show("No se puede borrar ya que la fila seleccionada está vacía, o el falta el valor de la columna InternalId");
                        return;
                    }

                    //donde el valor del InternalId coincida con el de la fila seleccionada se cambiará el valor de estaActivo
                    string cmdString = "UPDATE telefonosTable4 SET estaActivo = @activo WHERE InternalId =" + InternalId;

                    using (SqlConnection conn = new SqlConnection(datosConexion))
                    {
                        using (SqlCommand comm = new SqlCommand())
                        {
                            comm.Connection = conn;
                            comm.CommandText = cmdString;
                            comm.Parameters.AddWithValue("@activo", 0); //Cambia el valor de estaActivo

                            try
                            {
                                conn.Open();//se abre conexion
                                comm.ExecuteNonQuery();//se ejecuta el comando
                                MessageBox.Show("El valor de la columna estaActivo ha cambiado a 0,\n pulsa cargar para ver los cambios");
                                conn.Close();//se cierra conexion
                                //datagridView1.Rows.RemoveAt(this.datagridView1.SelectedRows[0].Index);
                            }
                            catch (SqlException)
                            {
                                MessageBox.Show("Error de Borrado");
                            }
                            if (this.datagridView1.Rows[selectedRow].Cells["estaActivo"].Value != null)
                            {
                                if (this.datagridView1.Rows[selectedRow].Cells["estaActivo"].Value is DBNull)
                                {
                                    MessageBox.Show("El valor de la columna estaActivo es null");
                                    return;
                                }
                                littleHider();
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hay que seleccionar una fila");
            }
        }
        // END BORRAR ROW EN DB

        // OCULTADOR DE FILAS GENERAL
        private void hider()// Oculta todas las filas con valor 0 en la columna estaActivo 
        {
            foreach (DataGridViewRow row in datagridView1.Rows)
            {
                if (row.Cells["estaActivo"].Value == DBNull.Value)//Si estaActivo es null:
                {
                    MessageBox.Show("Una de las filas tiene la columna estaActivo null, se mostrará vacía");

                    datagridView1.CurrentCell = null;
                    this.datagridView1.Columns["estaActivo"].Visible = true;

                    continue;
                }
                if (Convert.ToInt32(row.Cells["estaActivo"].Value) != 1)//Si estaActivo es distinto de 1:
                {
                    datagridView1.CurrentCell = null;//Se nulliza la celda para poder ocultarla
                    row.Visible = false;//se oculta
                }
            }
        }
        // END OCULTADOR DE FILAS GENERAL

        // OCULTADOR DE FILAS
        private void littleHider() // Oculta la fila seleccionada con valor 0 en la columna estaActivo 
        {
            int selectedRow = this.datagridView1.SelectedRows[0].Index;

            if (this.datagridView1.Rows[selectedRow].Cells["estaActivo"].Value is DBNull)//Si estaActivo es null:
            {
                MessageBox.Show("la columna estaActivo es null, Por lo que no se puede borrar");
                return;
            }
            if (Convert.ToInt32(this.datagridView1.Rows[selectedRow].Cells["estaActivo"].Value) != 1)//Si estaActivo es distinto de 1:
            {
                datagridView1.CurrentCell = null; //Se nulliza la celda para poder ocultarla
                datagridView1.Rows[selectedRow].Visible = false;//se oculta
                datagridView1.Rows.RemoveAt(this.datagridView1.SelectedRows[0].Index);//Se borra del datagridview
            }
        }
        // END OCULTADOR DE FILAS

        //UPDATE
        private void button_update_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(datosConexion))
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = "UPDATE telefonosTable4 SET updated = @updated";
                    comm.Parameters.AddWithValue("@updated", "sí"); //Cambia el valor de update a "Si"

                    try
                    {
                        conn.Open();//Abre conexion
                        comm.ExecuteNonQuery();//Ejecuta comando
                        MessageBox.Show("Se ha hecho Update con todos los registros");
                        conn.Close();//Cierra conexion
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error de Update");
                    }
                }
            }
        }
        // END UPDATE

        // CONTADOR DE FILAS
        private void rowsCounter()
        {
            var count = datagridView1.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["estaActivo"].Value != System.DBNull.Value);
            this.textBox_filas.Text = count.ToString();
            //MessageBox.Show("Numero de filas: " + count);
        }
        // END CONTADOR DE FILAS

        // CONTADOR DE INDICE
        //private void GetRowIndex()
        //{
        //    //Debug.Assert(this.datagridView1.CurrentCell.RowIndex == null, "Debes seleccionar la fila que quieres borrar");           
        //        int rowIndex = this.datagridView1.CurrentCell.RowIndex + 1;
        //        this.textBox_indice.Text = rowIndex.ToString();
        //        //MessageBox.Show("Indice de la fila seleccionada: " + rowIndex);            
        //}
        // END CONTADOR DE INDICE

        // CERRAR LA APLICACION
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("¿Quiere salir de la Lista Telefónica?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            base.OnFormClosing(e);
        }
        // END CERRAR LA APLICACION
    }
}


