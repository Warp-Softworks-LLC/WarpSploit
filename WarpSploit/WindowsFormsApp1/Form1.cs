using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using Microsoft.Toolkit.Uwp.Notifications;
using ForlornApi;
using System.IO;
using System.Drawing.Imaging;
using System.Text;
using System.Diagnostics;
namespace WarpSploit
{
    public partial class Form1 : Form
    {
        ColorWithAlpha color = new ColorWithAlpha();
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            int backdroptype = (int)DwmApi.DWMSYSTEMBACKDROPTYPE.DWMSBT_MAINWINDOW;
            DwmApi.DwmSetWindowAttribute(Handle, DwmApi.DWMWINDOWATTRIBUTE.SystemBackdropType, ref backdroptype, sizeof(int));
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            color.Alpha = 255;
            color.Color = AccentColorHelper.GetAccentColor();
            alphaGradientPanel1.Colors.Add(color);
            
            int UseDarkTheme = DwmApi.AppsUseDarkMode() ? 1 : 0;
            if (DwmApi.AppsUseDarkMode())
            {
                Editor.ForeColor = Color.White;
                this.ForeColor = Color.White;
                Editor.LineNumberColor = Color.White;
                txtChatLog.ForeColor = Color.White;
            } else
            {
                Editor.ForeColor = Color.FromArgb(20, 20, 20);
                this.ForeColor = Color.FromArgb(20, 20, 20);
                txtChatLog.ForeColor = Color.FromArgb(20, 20, 20);
                Editor.LineNumberColor = Color.FromArgb(20, 20, 20);
            }
            DwmApi.DwmSetWindowAttribute(Handle, DwmApi.DWMWINDOWATTRIBUTE.ImmersiveDarkMode, ref UseDarkTheme, sizeof(int));
        }


        private void alphaGradientPanel5_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/YG3DQH7mGW");
            new ToastContentBuilder()
               .AddText("WarpSploit")
               .AddText("The Discord invite has opened.")
               .Show();
        }

        private void alphaGradientPanel3_Click(object sender, System.EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                Editor.Text = File.ReadAllText(openFileDialog1.FileName);

            }
            catch
            {

            }
        }

        private void alphaGradientPanel2_Click(object sender, System.EventArgs e)
        {
            ForlornApi.Api.ExecuteScript(Editor.Text);
            new ToastContentBuilder()
               .AddText("WarpSploit")
               .AddText("Script executed!")
               .Show();
        }

        private void alphaGradientPanel1_Click(object sender, System.EventArgs e)
        {
            ForlornApi.Api.Inject();
            if (ForlornApi.Api.IsInjected())
            {
                new ToastContentBuilder()
                .AddText("WarpSploit")
                .AddText("WarpSploit has attached successfully!")
                .Show();
            }
        }

        private void alphaGradientPanel4_Click(object sender, System.EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (File.Exists(saveFileDialog1.FileName))
            {
                File.WriteAllText(saveFileDialog1.FileName, Editor.Text);

            }
            else
            {
                File.Create(saveFileDialog1.FileName).Write(Encoding.UTF8.GetBytes(Editor.Text), 0, Editor.TextLength);
            }
            new ToastContentBuilder()
               .AddText("WarpSploit")
               .AddText("Script saved successfully!")
               .Show();
        }
        private async void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.ActiveControl = null;
                // Get the input text
                string message = textBox1.Text;

                // Check if the message is not empty
                if (!string.IsNullOrWhiteSpace(message))
                {
                    // Add message to chat log
                    txtChatLog.AppendText(Environment.NewLine + $"[You]: {message}");

                    // Clear the input box
                    textBox1.Clear();
                    string AIMessage = await SendMessageToOpenAI(message);
                    txtChatLog.AppendText(Environment.NewLine + $"[Copilot]: {AIMessage}");
                }
            }
        }
        private async Task<string> SendMessageToOpenAI(string message)
        {
            string 
                behavior = "You are a assistant for WarpSploit (exploiting software/executor for Roblox). When the user says something exploit related, give them a script or a loadstring, or else, you can respond as intended.";


            using (HttpClient client = new HttpClient())
            {


                var requestBody = new
                {
                    model = "llama-3-8b-instruct",
                    messages = new[]
                    {
                        new { role = "system", content = behavior},
                        new { role = "user", content = message }
                    }
                };

                var requestContent = new StringContent(JsonSerializer.Serialize(requestBody), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("https://proxy.mubilop.tech/v1/chat/completions", requestContent);

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var jsonDoc = JsonDocument.Parse(jsonResponse);
                    return jsonDoc.RootElement
                        .GetProperty("choices")[0]
                        .GetProperty("message")
                        .GetProperty("content")
                        .GetString();
                }
                else
                {
                    return "Error: Unable to contact the API. Please try again later.";
                }
            }
        }

    }
}
