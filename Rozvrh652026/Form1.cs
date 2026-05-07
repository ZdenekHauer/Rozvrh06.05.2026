using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;

namespace Rozvrh652026;



public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    
    
    private async void btnNacist_Click(object sender, EventArgs e)
    {
        using HttpClient client = new HttpClient();

        string url = "https://rozvrh.adamhojer.cz/2A/wednesday/subjects?group=A1"; 

        var json = await client.GetStringAsync(url);

        var subjects = JsonSerializer.Deserialize<List<string>>(json);

        int body = 0; 
        
        foreach (var s in subjects)
        {
            switch (s.ToUpper())
            {
                case "AAP": body += 3; break;
                case "PSI": body += 1; break;
                case "AJ": body += 5; break;
                case "EAF": body += 6; break;
                case "ASW": body += 1; break;
                case "N": body += 7; break;
                default: body += 0; break;
            }
        }
        
        int max = subjects.Count * 10;

        lblVysledek.Text = $"Body: {body} / {max}";
        
        if (body < 20)
            lblVysledek.ForeColor = Color.Red;
        else if (body < 40)
            lblVysledek.ForeColor = Color.Orange;
        else
            lblVysledek.ForeColor = Color.Green;
        
    }
}