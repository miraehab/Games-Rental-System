﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Games_Rental_System{
    public partial class Register : Form{
        public Register(){
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e){
            SqlConnection con = new SqlConnection(@"Data Source=MISHOO; Initial Catalog=Game-Over;Integrated Security=True");
            try{
                con.Open();
                string _userName = inpUserName.Text.ToString();
                string _password = inpPassword.Text.ToString();
                string _confirmPassword = inpPasswordConfirm.Text.ToString();
                string _Query = "SELECT A_USERNAME FROM ADMIN WHERE A_USERNAME='" + _userName + "';";
                string _Query2 = "insert into ADMIN VALUES ('" + _userName + "','" + _password + "');";
                SqlCommand command;
                command = new SqlCommand(_Query, con);
                SqlDataReader data = command.ExecuteReader();
                if (data.Read()){
                  MessageBox.Show("User already exists");
                }
                else{
                    data.Close();
                    if (_password == _confirmPassword){
                        command = new SqlCommand(_Query2, con);
                        command.ExecuteNonQuery();
                        MessageBox.Show("User added successfully");
                        this.Hide();
                    }
                    else{

                        MessageBox.Show("The two passwords are not the same");
                    }
                }
                con.Close();
            }
            catch (Exception ex){
                MessageBox.Show("error connecting to database");
            }
        }
    }
}
