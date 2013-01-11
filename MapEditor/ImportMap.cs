﻿/* 
  koolk's Map Editor
 
  Copyright (c) 2009-2013 koolk

  This software is provided 'as-is', without any express or implied
  warranty. In no event will the authors be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

     1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.

     2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.

     3. This notice may not be removed or altered from any source
     distribution.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WZ;

namespace WZMapEditor
{
    public partial class ImportMap : Form
    {
        public bool Canceled = true;

        public ImportMap(string ID)
        {
            InitializeComponent();

            this.MapID.Text = ID;

            List<string> GroupNames = new List<string>();

            IMGFile maps = MapEditor.stringf.Directory.GetIMG("Map.img");

            string[] array = new string[maps.childs.Keys.Count];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = maps.childs[i].Name;
            }

            MapGroup.Items.AddRange(array);
        }

        private void ImportMap_Load(object sender, EventArgs e)
        {

        }

        private void Import_Click(object sender, EventArgs e)
        {
            Canceled = false;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
