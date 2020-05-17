﻿using System;
using System.Windows.Forms;

using static TorreDeBabel.baseLangueDataSet;

namespace TorreDeBabel {
public partial class frmTableauBord : Form {
#region Propriétés
TableLayoutPanel	tlpMain;
#endregion
#region Constructeurs
public
frmTableauBord(UtilisateursRow user)
{
	SuspendLayout();
	components = new System.ComponentModel.Container();

	tlpMain = new TableLayoutPanel() {
		ColumnCount = 1
	};

	ResumeLayout();
}
#endregion
#region Méthodes
private void
ChooseLesson(LeconsRow lecon)
{
	frmLecon frmLecon;

	frmLecon = new frmLecon(lecon);

	/* Si l'utilisateur a bien terminé la lecon */
	if (frmLecon.ShowDialog() == DialogResult.OK)
		UpdateProgress();
}

private void
UpdateProgress()
{

}
#endregion
}
}
