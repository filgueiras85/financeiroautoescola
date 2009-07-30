using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GerenciadorFinanceiro.Servicos
{
    class Backup
    {

        public void RealizarBackupBancoDados(String pathLocalBanco, String pathLocalBackup)
        {
            String localBanco = System.IO.Path.Combine(pathLocalBanco, "DBGerenciador.sdf");
            String localBancoBackup = System.IO.Path.Combine(pathLocalBackup, "DBGerenciador.sdf");
            String localBancoBackupDoBackup = System.IO.Path.Combine(pathLocalBackup, "Backup");
            if (System.IO.File.Exists(localBanco))
            {
                if (System.IO.File.Exists(localBancoBackup))
                {
                    if (System.IO.Directory.Exists(localBancoBackupDoBackup) == false)
                        System.IO.Directory.CreateDirectory(localBancoBackupDoBackup);
                    if (System.IO.File.Exists(System.IO.Path.Combine(localBancoBackupDoBackup, "DBGerenciador.sdf")))
                    {
                        System.IO.File.SetAttributes(System.IO.Path.Combine(localBancoBackupDoBackup, "DBGerenciador.sdf"), System.IO.FileAttributes.Normal);
                        System.IO.File.Delete(System.IO.Path.Combine(localBancoBackupDoBackup, "DBGerenciador.sdf"));
                    }
                    System.IO.File.Copy(localBancoBackup, System.IO.Path.Combine(localBancoBackupDoBackup, "DBGerenciador.sdf"));
                    System.IO.File.SetAttributes(localBancoBackup, System.IO.FileAttributes.Normal);
                    System.IO.File.Delete(localBancoBackup);
                }
                System.IO.File.Copy(localBanco, localBancoBackup);
                System.Windows.Forms.MessageBox.Show("Backup realizado com sucesso.", "Aviso");
            }
            else
                System.Windows.Forms.MessageBox.Show("Caminho do banco de dados inválido.", "Atenção");
        }

        public void RestaurarBancoDados()
        {
            String localBanco = System.IO.Path.Combine(Properties.Settings.Default.LocalDB, "DBGerenciador.sdf");
            String localBackup = System.IO.Path.Combine(Properties.Settings.Default.LocalBackupDB, "DBGerenciador.sdf");
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
                System.Windows.Forms.MessageBox.Show("Banco restaurado com sucesso.", "Aviso");
            }else
                System.Windows.Forms.MessageBox.Show("Nenhum backup encontrado.", "Atenção");
        }

    }
}
