﻿using ASSISTENTE_E2.Engine;
using ASSISTENTE_E2.Log;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSISTENTE_E2.View
{
    internal sealed partial class LoadingView : Form
    {
        internal LoadingView()
        {
            InitializeComponent();
            Text = $"{PRController.Name} carregando...";
            Icon = PRController.Icon;
        }

        private void LoadingView_Load(object sender, EventArgs @event)
        {
            LogPack.AddMessageLog("Iniciando carregamento do sistema");

            try
            {
                var syn = new SynthesizerEngine();
                syn.Speak("Carregando");

                #region MainVew
                var mainView = new MainView();
                LogPack.AddMessageLog("MainView Carregado!");
                #endregion

                #region Carrega eventos do synthesizer
                mainView.Synthesizer.SpeakStarting += mainView.SpeakStarted;
                mainView.Synthesizer.SpeakInProgress += mainView.SpeakInProgress;
                mainView.Synthesizer.SpeakComplete += mainView.SpeakCompleted;
                #endregion

                #region Carrega eventos do recognizer
                mainView.Recognizer.SpeechDetected += mainView.SpeechDetected;
                mainView.Recognizer.SpeechRecognized += mainView.SpeechRecognized;
                mainView.Recognizer.SpeechRecognitionRejected += mainView.SpeechRejected;
                #endregion


                LogPack.AddMessageLog("Sistema carregado com sucesso!");
                Program.Switch(this, mainView);
            }
            catch (Exception e)
            {
                LogPack.AddErrorLog("Carregando Sistema", e);
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
