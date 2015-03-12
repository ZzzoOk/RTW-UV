using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTW_UV
{
    class Unit
    {
        public string type,
              //dictionary,
              category,
              /*clas,
              voice_type,
              soldier,
              officer,
              mount,
              mount_effect,
              attributes,
              formation,
              stat_health,
              stat_pri,
              stat_pri_attr,
              stat_sec,
              stat_sec_attr,
              stat_pri_armour,
              stat_sec_armour,
              stat_heat,
              stat_ground,
              stat_mental,
              stat_charge_dist,
              stat_fire_delay,
              stat_food,
              stat_cost,*/
              ownership;

        public Unit(string type, /*string dictionary,*/ string category, /*string clas, string voice_type, string soldier, string officer, string mount, string mount_effect, string attributes, string formation, string stat_health, string stat_pri, string stat_pri_attr, string stat_sec, string stat_sec_attr, string stat_pri_armour, string stat_sec_armour, string stat_heat, string stat_ground, string stat_mental, string stat_charge_dist, string stat_fire_delay, string stat_food, string stat_cost,*/ string ownership)
        {
            this.type = type.Substring(type.IndexOf(' ')).Trim();
            //this.dictionary = dictionary.Substring(dictionary.IndexOf(' ')).Trim();
            this.category = category.Substring(category.IndexOf(' ')).Trim();
            /*this.clas = clas.Substring(clas.IndexOf(' ')).Trim();
            this.voice_type = voice_type.Substring(voice_type.IndexOf(' ')).Trim();
            this.soldier = soldier.Substring(soldier.IndexOf(' ')).Trim();
            this.officer = (officer != "") ? officer.Substring(officer.IndexOf(' ')).Trim() : "";
            this.mount = (mount != "") ? mount.Substring(mount.IndexOf(' ')).Trim() : "";
            this.mount_effect = (mount_effect != "") ? mount_effect.Substring(mount_effect.IndexOf(' ')).Trim() : "";
            this.attributes = attributes.Substring(attributes.IndexOf(' ')).Trim();
            this.formation = formation.Substring(formation.IndexOf(' ')).Trim();
            this.stat_health = stat_health.Substring(stat_health.IndexOf(' ')).Trim();
            this.stat_pri = stat_pri.Substring(stat_pri.IndexOf(' ')).Trim();
            this.stat_pri_attr = stat_pri_attr.Substring(stat_pri_attr.IndexOf(' ')).Trim();
            this.stat_sec = stat_sec.Substring(stat_sec.IndexOf(' ')).Trim();
            this.stat_sec_attr = stat_sec_attr.Substring(stat_sec_attr.IndexOf(' ')).Trim();
            this.stat_pri_armour = stat_pri_armour.Substring(stat_pri_armour.IndexOf(' ')).Trim();
            this.stat_sec_armour = stat_sec_armour.Substring(stat_sec_armour.IndexOf(' ')).Trim();
            this.stat_heat = stat_heat.Substring(stat_heat.IndexOf(' ')).Trim();
            this.stat_ground = stat_ground.Substring(stat_ground.IndexOf(' ')).Trim();
            this.stat_mental = stat_mental.Substring(stat_mental.IndexOf(' ')).Trim();
            this.stat_charge_dist = stat_charge_dist.Substring(stat_charge_dist.IndexOf(' ')).Trim();
            this.stat_fire_delay = stat_fire_delay.Substring(stat_fire_delay.IndexOf(' ')).Trim();
            this.stat_food = stat_food.Substring(stat_food.IndexOf(' ')).Trim();
            this.stat_cost = stat_cost.Substring(stat_cost.IndexOf(' ')).Trim();*/
            this.ownership = ownership.Substring(ownership.IndexOf(' ')).Trim();
        }
    }
}
