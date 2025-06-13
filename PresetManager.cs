using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCOPresets
{
    public static class PresetManager
    {
        public static Preset? GetPresetByName(string name)
        {
            string? presetsPath = Path.Join(Environment.CurrentDirectory, "presets.json");
            if (!File.Exists(presetsPath))
            {
                return null;
            }

            try
            {
                string? json = File.ReadAllText(presetsPath);
                var presetsRoot = JsonConvert.DeserializeObject<PresetsRoot>(json);
                if (presetsRoot?.Presets == null)
                {
                    return null;
                }

                return presetsRoot.Presets?.FirstOrDefault(p =>
                    string.Equals(
                        p.Name,
                        name,
                        StringComparison.OrdinalIgnoreCase
                    )
                );
            }
            catch
            {
                return null;
            }
        }
    }
}
