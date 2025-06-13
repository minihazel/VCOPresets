using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VCOPresets
{
    public static class PresetManager
    {
        public static bool SavePreset(Preset name, string currentEnv)
        {
            string presetsPath = Path.Join(currentEnv, "presets.json");
            PresetsRoot? presetsRoot = null;

            if (File.Exists(presetsPath))
            {
                string json = File.ReadAllText(presetsPath);
                presetsRoot = JsonConvert.DeserializeObject<PresetsRoot>(json) ??
                new PresetsRoot {
                    Presets = new List<Preset>()
                };
            }
            else
            {
                presetsRoot = new PresetsRoot {
                    Presets = new List<Preset>()
                };
            }

            if (presetsRoot.Presets.Any(p => string.Equals(p.Name, name.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }

            presetsRoot.Presets.Add(name);
            string updatedJson = JsonConvert.SerializeObject(presetsRoot, Formatting.Indented);
            File.WriteAllText(presetsPath, updatedJson);
            return true;
        }

        public static Preset? GetPresetByName(string name, string currentEnv)
        {
            string? presetsPath = Path.Join(currentEnv, "presets.json");
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

        public static bool RemovePreset(string presetName, string currentEnv)
        {
            string presetsPath = Path.Join(currentEnv, "presets.json");
            if (!File.Exists(presetsPath))
                return false;

            try
            {
                string json = File.ReadAllText(presetsPath);
                var root = JsonConvert.DeserializeObject<PresetsRoot>(json);
                if (root?.Presets == null)
                {
                    return false;
                }

                var targetPreset = root.Presets.FirstOrDefault(p => string.Equals(p.Name, presetName, StringComparison.OrdinalIgnoreCase));
                if (targetPreset == null)
                {
                    return false;
                }

                root.Presets.Remove(targetPreset);
                string updatedJson = JsonConvert.SerializeObject(root, Formatting.Indented);
                File.WriteAllText(presetsPath, updatedJson);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
