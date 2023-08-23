
namespace CartaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.iconConfig = new FontAwesome.Sharp.IconMenuItem();
            this.iconVentas = new FontAwesome.Sharp.IconMenuItem();
            this.iconCompras = new FontAwesome.Sharp.IconMenuItem();
            this.iconClient = new FontAwesome.Sharp.IconMenuItem();
            this.iconProveedor = new FontAwesome.Sharp.IconMenuItem();
            this.iconReport = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.RosyBrown;
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuTitulo.Size = new System.Drawing.Size(841, 62);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sitema de Ventas";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1,
            this.iconConfig,
            this.iconVentas,
            this.iconCompras,
            this.iconClient,
            this.iconProveedor,
            this.iconReport});
            this.menu.Location = new System.Drawing.Point(0, 62);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu.Size = new System.Drawing.Size(841, 75);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // iconConfig
            // 
            this.iconConfig.ForeColor = System.Drawing.Color.Black;
            this.iconConfig.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.iconConfig.IconColor = System.Drawing.Color.Black;
            this.iconConfig.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconConfig.IconSize = 50;
            this.iconConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconConfig.Name = "iconConfig";
            this.iconConfig.Size = new System.Drawing.Size(101, 69);
            this.iconConfig.Text = "Mantenimiento";
            this.iconConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconVentas
            // 
            this.iconVentas.ForeColor = System.Drawing.Color.Black;
            this.iconVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.iconVentas.IconColor = System.Drawing.Color.Black;
            this.iconVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconVentas.IconSize = 50;
            this.iconVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconVentas.Name = "iconVentas";
            this.iconVentas.Size = new System.Drawing.Size(62, 69);
            this.iconVentas.Text = "Ventas";
            this.iconVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconCompras
            // 
            this.iconCompras.ForeColor = System.Drawing.Color.Black;
            this.iconCompras.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            this.iconCompras.IconColor = System.Drawing.Color.Black;
            this.iconCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCompras.IconSize = 50;
            this.iconCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconCompras.Name = "iconCompras";
            this.iconCompras.Size = new System.Drawing.Size(67, 69);
            this.iconCompras.Text = "Compras";
            this.iconCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconClient
            // 
            this.iconClient.ForeColor = System.Drawing.Color.Black;
            this.iconClient.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.iconClient.IconColor = System.Drawing.Color.Black;
            this.iconClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconClient.IconSize = 50;
            this.iconClient.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconClient.Name = "iconClient";
            this.iconClient.Size = new System.Drawing.Size(62, 69);
            this.iconClient.Text = "Clientes";
            this.iconClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconProveedor
            // 
            this.iconProveedor.ForeColor = System.Drawing.Color.Black;
            this.iconProveedor.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconProveedor.IconColor = System.Drawing.Color.Black;
            this.iconProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProveedor.IconSize = 50;
            this.iconProveedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconProveedor.Name = "iconProveedor";
            this.iconProveedor.Size = new System.Drawing.Size(84, 69);
            this.iconProveedor.Text = "Proveedores";
            this.iconProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconReport
            // 
            this.iconReport.ForeColor = System.Drawing.Color.Black;
            this.iconReport.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconReport.IconColor = System.Drawing.Color.Black;
            this.iconReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconReport.IconSize = 50;
            this.iconReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconReport.Name = "iconReport";
            this.iconReport.Size = new System.Drawing.Size(65, 69);
            this.iconReport.Text = "Reportes";
            this.iconReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.IconSize = 50;
            this.iconMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(64, 69);
            this.iconMenuItem1.Text = "Usuarios";
            this.iconMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Inicio";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem iconConfig;
        private FontAwesome.Sharp.IconMenuItem iconVentas;
        private FontAwesome.Sharp.IconMenuItem iconCompras;
        private FontAwesome.Sharp.IconMenuItem iconClient;
        private FontAwesome.Sharp.IconMenuItem iconProveedor;
        private FontAwesome.Sharp.IconMenuItem iconReport;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
    }
}

