using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesDisk
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				List<string> errors = new List<string>();
				DriveInfo[] myDrives = DriveInfo.GetDrives();
				using (var db = new SeriesDisqueDataContext())
				{
					foreach (DriveInfo drive in myDrives)
					{
						if (drive.IsReady == true)
						{
							var vol = drive.VolumeLabel;
							if (vol.StartsWith("SERIES"))
							{
								int inserted = 0;
								int updated = 0;
								int nbseries = 0;
								var did = GetDisqueId(db, vol);
								Console.WriteLine("[{0}][{1}] {2}", did, drive.Name, vol);
								foreach (var d in Directory.GetDirectories(Path.Combine(drive.Name, "Séries")))
								{
									nbseries++;
									var nom = ExtractName(d);
									Console.WriteLine(nom);
									var s = GetSerie(db, nom);
									if (s == null)
									{
										// On ajoute la série
										s = new t_serie();
										s.serie_an = 0;
										s.serie_nom = nom;
										s.disque_id = did;
										s.serie_maj = DateTime.Now;
										db.t_serie.InsertOnSubmit(s);
										db.SubmitChanges();
										inserted++;
									}
									else
									{
										if (s.disque_id != did)
										{
											// On met à jour le disque
											errors.Add(String.Format("[{0}][{1,6:# ##0}] {2}", did, s.serie_id, s.serie_nom));
											s.disque_id = did;
											db.SubmitChanges();
											updated++;
										}
									}
								}
								Console.WriteLine("Nombre de séries : {0,6:# ##0}", nbseries);
								Console.WriteLine("Inserted         : {0,6:# ##0}", inserted);
								Console.WriteLine("Updates          : {0,6:# ##0}", updated);
							}
						}
					}
					foreach (var err in errors)
					{
						Console.WriteLine(err);
					}
				}
			}
			catch (Exception)
			{
				throw;
			}
			Console.WriteLine("FIN");
			Console.ReadLine();
		}

		private static string ExtractName(string d)
		{
			return d.Split('\\').Last();
		}

		private static int GetDisqueId(SeriesDisqueDataContext db, string vol)
		{
			return db.t_disque.Where(o => o.disque_vol_name == vol).Select(o => o.disque_id).SingleOrDefault();
		}

		private static t_serie GetSerie(SeriesDisqueDataContext db, string nom)
		{
			return db.t_serie.Where(o => o.serie_nom == nom).SingleOrDefault();
		}
	}
}
