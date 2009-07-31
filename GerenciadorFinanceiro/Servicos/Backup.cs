using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Servicos
{
    class Backup
    {

        public void RealizarBackupBancoDados(String pathLocalBanco, String pathLocalBackup)
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            String localBanco = System.IO.Path.Combine(pathLocalBanco, "DBGerenciador.sdf");
            String dataBackup = "Backup_" + String.Format("{0:00}", dia) + "-" + String.Format("{0:00}", mes) + "-" + String.Format("{0:0000}", ano);
            String localBackup = System.IO.Path.Combine(pathLocalBackup, dataBackup);
            String bancoBackup = System.IO.Path.Combine(localBackup, "DBGerenciador.sdf");
            if (File.Exists(localBanco))
            {
                if (File.Exists(bancoBackup))
                {
                    File.SetAttributes(bancoBackup, FileAttributes.Normal);
                    File.Delete(bancoBackup);
                }
                if (Directory.Exists(localBackup) == false)
                    Directory.CreateDirectory(localBackup);
                File.Copy(localBanco, bancoBackup);
                System.Windows.Forms.MessageBox.Show("Backup realizado com sucesso.", "Aviso");
            }
            else
                System.Windows.Forms.MessageBox.Show("Caminho do banco de dados inválido.", "Atenção");
        }

        public void RealizarBackupBancoDados()
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            String localBanco = System.IO.Path.Combine(Properties.Settings.Default.LocalDB, "DBGerenciador.sdf");
            String dataBackup = "Backup_" + String.Format("{0:00}", dia) + "-" + String.Format("{0:00}", mes) + "-" + String.Format("{0:0000}", ano);
            String localBackup = System.IO.Path.Combine(Properties.Settings.Default.LocalBackupDB, dataBackup);
            String bancoBackup = System.IO.Path.Combine(localBackup, "DBGerenciador.sdf");
            if (File.Exists(localBanco))
            {
                if (File.Exists(bancoBackup))
                {
                    File.SetAttributes(bancoBackup, FileAttributes.Normal);
                    File.Delete(bancoBackup);
                }
                if (Directory.Exists(localBackup) == false)
                    Directory.CreateDirectory(localBackup);
                File.Copy(localBanco, bancoBackup);
                System.Windows.Forms.MessageBox.Show("Backup realizado com sucesso.", "Aviso");
            }
            else
                System.Windows.Forms.MessageBox.Show("Caminho do banco de dados inválido.", "Atenção");
        }

        public String[] ListarTodosOsBackup() 
        {
            String[] diretoriosDeBackup = null;
            String dirPadrao = Properties.Settings.Default.LocalBackupDB;
            String subDiretorio = "Backup_*";
            if (Directory.Exists(dirPadrao) == true)
                diretoriosDeBackup = Directory.GetDirectories(dirPadrao, subDiretorio);
            return diretoriosDeBackup;
        }
        
        public void RestaurarBancoDados(String backupRestaurar)
        {
            String localBanco = System.IO.Path.Combine(Properties.Settings.Default.LocalDB, "DBGerenciador.sdf");
            String localBackup = System.IO.Path.Combine(backupRestaurar, "DBGerenciador.sdf");
            String localBackupTemp = System.IO.Path.Combine(Properties.Settings.Default.LocalDB, "Backup");
            if (System.IO.File.Exists(localBackup))
            {
                if (System.IO.File.Exists(localBanco))
                {
                    if (System.IO.Directory.Exists(localBackupTemp) == false)
                        System.IO.Directory.CreateDirectory(localBackupTemp);
                    if (System.IO.File.Exists(System.IO.Path.Combine(localBackupTemp, "DBGerenciador.sdf")))
                    {
                        System.IO.File.SetAttributes(System.IO.Path.Combine(localBackupTemp, "DBGerenciador.sdf"), System.IO.FileAttributes.Normal);
                        System.IO.File.Delete(System.IO.Path.Combine(localBackupTemp, "DBGerenciador.sdf"));
                    }
                    System.IO.File.Copy(localBanco, System.IO.Path.Combine(localBackupTemp, "DBGerenciador.sdf"));
                    System.IO.File.SetAttributes(localBanco, System.IO.FileAttributes.Normal);
                    System.IO.File.Delete(localBanco);
                }
                System.IO.File.Copy(localBackup, localBanco);
                System.Windows.Forms.MessageBox.Show("O Sistema foi restaurado com sucesso.", "Aviso");
            }else
                System.Windows.Forms.MessageBox.Show("Nenhum backup encontrado.", "Atenção");
        }

    }
}
