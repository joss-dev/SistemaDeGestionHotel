﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SistemaDeGestionHotel.SGHControl
{
    public class MenuRenderer : ToolStripProfessionalRenderer
    {
        //Campos
        private Color primaryColor;
        private Color textColor;
        private int arrowsThickness;

        //Constructor
        public MenuRenderer(bool isMainMenu, Color primaryColor, Color textColor)
            : base(new MenuColorTable(isMainMenu, primaryColor))
        { 
            this.primaryColor = primaryColor;
            this.textColor = primaryColor;
            if (isMainMenu) arrowsThickness = 3;
                else arrowsThickness = 2;
        }

        //Overrides
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            e.Item.ForeColor = e.Item.Selected ? Color.White : primaryColor;
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            //Campos
            var graph = e.Graphics;
            var ArrowSize = new Size(5, 12);
            var arrowColor = e.Item.Selected ? Color.White : primaryColor;
            var rect = new Rectangle(e.ArrowRectangle.Location.X, (e.ArrowRectangle.Height-ArrowSize.Height) / 2, ArrowSize.Width, ArrowSize.Height);
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(arrowColor, arrowsThickness))
            {
                //Drawing
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top + rect.Height / 2);
                path.AddLine(rect.Right, rect.Top + rect.Height / 2, rect.Left, rect.Top + rect.Height);
                graph.DrawPath(pen, path);
            }
        }
    }
 }



