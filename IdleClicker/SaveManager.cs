using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IdleClicker
{
    public static class SaveManager
    {
        private static string fileName = "savegame.json";
        private static string fullPath = Path.Combine(Application.StartupPath, fileName);

        // Metoda pro uložení
        public static void Save(SaveData data)
        {
            try
            {
                // Převede objekt na čitelný text (WriteIndented zajistí hezké formátování)
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(data, options);

                File.WriteAllText(fullPath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při ukládání: " + ex.Message);
            }
        }

        // Metoda pro načtení
        public static SaveData Load()
        {
            if (File.Exists(fullPath)) // Existuje soubor na disku?
            {
                // ANO -> Přečti ho a převeď na data
                string jsonString = File.ReadAllText(fullPath);
                return JsonSerializer.Deserialize<SaveData>(jsonString);
            }
            else
            {
                // NE -> Vytvoř úplně nová data (všechno bude na nule/základu)
                return new SaveData();
            }
        }
    }
}
