﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class GameScreen : UserControl
    {
        List<Dice> diceList = new List<Dice> { };

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        private void OnStart()
        {

        }

        private void OnEnd()
        {

        }
    }
}
