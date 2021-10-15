using System;
using System.Timers;
namespace cptRebours
{
    public class Decompteur
	{

		int donnee = 10;
		private int Val;
		private int periode;
		private Fen_Principale fen_Principale;

		public Decompteur()
		{
			
			timer = new Timer(1000);
			timer.Elapsed += Decompter;

		}
		public void Demarrer()
		{
			timer.Start();

		}
		public void Stopper()
        {
			if (donnee == 0)
			{
				timer.Stop();
			}
        }

		private void Decompter(object sender, ElapsedEventArgs e)
		{
			donnee--;
			fen_Principale.afficher(donnee);
			
		}
		
		public int GetDonee()
		{
			return this.Val;
		}
		public void SetDonee(ref int Donnee)
		{
			this.Val = Donnee;
		}
		public int GetPeriode()
		{
			return this.periode;
		}
		public void SetPeriode(ref int periode)
		{
			this.periode = periode;
		}
		public void Decompter()
		{
			throw new System.NotImplementedException("Not implemented");
		}
		public void SetDecompteur(Fen_Principale fen_Principale)
		{
			this.fen_Principale = fen_Principale;
		}

		private Timer timer;

		private App app;

	}
}
