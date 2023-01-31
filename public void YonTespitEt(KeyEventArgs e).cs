public void YonTespitEt(KeyEventArgs e)
{
	if (yonDegisti)
		return;
	
	Yon eskiYon = yilaninYonu;

	if (yilaninYonu != Yon.YUKARI)
	{
		if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
		{
			yilaninYonu = Yon.ASAGI;
		}
	}
	if (yilaninYonu!=Yon.SOL)
	{
		if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
		{
			yilaninYonu = Yon.SAG;
		}            
	}
	if (yilaninYonu!=Yon.SAG)
	{
		if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
		{
			yilaninYonu = Yon.SOL;
		}
	
	}
	if (yilaninYonu != Yon.ASAGI)
	{
		if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
		{
			yilaninYonu = Yon.YUKARI;
		}
	}

	if (eskiYon != yilaninYonu)
	{
		yonDegisti = true;
	}
}
