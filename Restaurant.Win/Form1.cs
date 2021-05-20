using Microsoft.AspNetCore.SignalR.Client;
using Restaurant.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.Win
{
    public partial class CreateFoodForm : Form
    {
        private readonly HubConnection _hubConnection;
        private bool _isHubConnectionStarted;
        public CreateFoodForm()
        {
            InitializeComponent();
            _hubConnection = new HubConnectionBuilder()
                .WithAutomaticReconnect()
                .WithUrl("http://localhost:14984/FoodsHub")
                .Build();



        }

        private async void CreateFoodButton_Click(object sender, EventArgs e)
        {
            if (_isHubConnectionStarted is false)
            {
                await _hubConnection.StartAsync();
                _isHubConnectionStarted = true;
            }

            CreateFoodDto createFoodDto = new CreateFoodDto
            {
                Name = NameTextBox.Text,
                Description = DescriptionTextBox.Text,
                Ingredients = IngredientsTextBox.Text,
            };

            await _hubConnection.SendAsync("CreateFood", createFoodDto);

           _hubConnection.On<bool>("CreateFoodResult", handler =>
           {
               if (handler)
               {
                   MessageBox.Show("Created.");
                  
                   NameTextBox.Clear();
                   DescriptionTextBox.Clear();
                   IngredientsTextBox.Clear();
               }
               else
               {
                   MessageBox.Show("Faild to create.");
               }
           });
        }
    }
}
