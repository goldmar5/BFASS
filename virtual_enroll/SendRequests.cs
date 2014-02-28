using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CookComputing.XmlRpc;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Collections.Specialized;

namespace BFASS
{

    public struct DeviceInfo
    {
        public string lid;
        public string num;
        public string type;
        public string sid;
    }

    public class SendRequests
    {
       
        [XmlRpcUrl("http://127.0.0.1:8000")]
        public interface ISend
        {
            [XmlRpcMethod("get_packet")]
            string get_packet(string hello, string a, string b, string c, string d);

            [XmlRpcMethod("version")]
            string version();

            [XmlRpcMethod("enroll")]
            int enroll(string dev_type, string long_id);

            [XmlRpcMethod("enroll_to_zone")]
            int enroll_to_zone(string dev_type, string long_id, string zone_num);
            
            [XmlRpcMethod("get_all_devices")]
            DeviceInfo[] get_all_devices();
            
            [XmlRpcMethod("remove_device")]
            void remove_device(string short_id, string long_id);
            
            [XmlRpcMethod("remove_all_devices")]
            void remove_all_devices();

            [XmlRpcMethod("update_all_devices")]
            void update_all_devices();

            [XmlRpcMethod("get_lcd")]
            string get_lcd();

            [XmlRpcMethod("clear_device_pool")]
            void clear_device_pool();

            [XmlRpcMethod("key_load_test")]
            void key_load_test(string cycles, string delay);

            [XmlRpcMethod("ok_load_test")]
            void ok_load_test(string cycles, string delay);

            [XmlRpcMethod("open_tamper")]
            void open_tamper(string short_id, string long_id);

            [XmlRpcMethod("close_tamper")]
            void close_tamper(string short_id, string long_id);

            [XmlRpcMethod("send_key")]
            void send_key(string name);
            
            [XmlRpcMethod("violate")]
            void violate(string short_id, string long_id);

            [XmlRpcMethod("glass_break")]
            void glass_break(string short_id, string long_id);

            [XmlRpcMethod("open")]
            void open(string short_id, string long_id);

            [XmlRpcMethod("close")]
            void close(string short_id, string long_id);

            [XmlRpcMethod("open_smoke_alarm")]
            void open_smoke_alarm(string short_id, string long_id);

            [XmlRpcMethod("close_smoke_alarm")]
            void close_smoke_alarm(string short_id, string long_id);

            [XmlRpcMethod("open_heat_alarm")]
            void open_heat_alarm(string short_id, string long_id);

            [XmlRpcMethod("close_heat_alarm")]
            void close_heat_alarm(string short_id, string long_id);

            [XmlRpcMethod("open_co_alert")]
            void open_co_alert(string short_id, string long_id);

            [XmlRpcMethod("close_co_alert")]
            void close_co_alert(string short_id, string long_id);

            [XmlRpcMethod("open_gas_alert")]
            void open_gas_alert(string short_id, string long_id);

            [XmlRpcMethod("close_gas_alert")]
            void close_gas_alert(string short_id, string long_id);

            [XmlRpcMethod("open_flood")]
            void open_flood(string short_id, string long_id);

            [XmlRpcMethod("close_flood")]
            void close_flood(string short_id, string long_id);

            [XmlRpcMethod("open_aux")]
            void open_aux(string short_id, string long_id);

            [XmlRpcMethod("close_aux")]
            void close_aux(string short_id, string long_id);

            [XmlRpcMethod("open_freezer")]
            void open_freezer(string short_id, string long_id);

            [XmlRpcMethod("close_freezer")]
            void close_freezer(string short_id, string long_id);

            [XmlRpcMethod("open_freezing")]
            void open_freezing(string short_id, string long_id);

            [XmlRpcMethod("close_freezing")]
            void close_freezing(string short_id, string long_id);

            [XmlRpcMethod("open_hot")]
            void open_hot(string short_id, string long_id);

            [XmlRpcMethod("close_hot")]
            void close_hot(string short_id, string long_id);

            [XmlRpcMethod("open_cold")]
            void open_cold(string short_id, string long_id);

            [XmlRpcMethod("close_cold")]
            void close_cold(string short_id, string long_id);
            
            [XmlRpcMethod("panic")]
            void panic(string short_id, string long_id);

            [XmlRpcMethod("fire")]
            void fire(string short_id, string long_id);

            [XmlRpcMethod("emergency")]
            void emergency(string short_id, string long_id);

            [XmlRpcMethod("open_low_bat")]
            void open_low_bat(string short_id, string long_id);

            [XmlRpcMethod("close_low_bat")]
            void close_low_bat(string short_id, string long_id);

            [XmlRpcMethod("ac_fail")]
            void ac_fail(string short_id, string long_id);

            [XmlRpcMethod("ac_rest")]
            void ac_rest(string short_id, string long_id);

            [XmlRpcMethod("open_masking")]
            void open_masking(string short_id, string long_id);

            [XmlRpcMethod("close_masking")]
            void close_masking(string short_id, string long_id);

            [XmlRpcMethod("open_heat_trouble")]
            void open_heat_trouble(string short_id, string long_id);

            [XmlRpcMethod("close_heat_trouble")]
            void close_heat_trouble(string short_id, string long_id);

            [XmlRpcMethod("open_smoke_trouble")]
            void open_smoke_trouble(string short_id, string long_id);

            [XmlRpcMethod("close_smoke_trouble")]
            void close_smoke_trouble(string short_id, string long_id);

            [XmlRpcMethod("open_jamming")]
            void open_jamming(string short_id, string long_id);

            [XmlRpcMethod("close_jamming")]
            void close_jamming(string short_id, string long_id);

            [XmlRpcMethod("open_probe")]
            void open_probe(string short_id, string long_id);

            [XmlRpcMethod("close_probe")]
            void close_probe(string short_id, string long_id);

            [XmlRpcMethod("open_co_trouble")]
            void open_co_trouble(string short_id, string long_id);

            [XmlRpcMethod("close_co_trouble")]
            void close_co_trouble(string short_id, string long_id);

            [XmlRpcMethod("open_gas_trouble")]
            void open_gas_trouble(string short_id, string long_id);

            [XmlRpcMethod("close_gas_trouble")]
            void close_gas_trouble(string short_id, string long_id);

            [XmlRpcMethod("back_to_factory_defaults")]
            void back_to_factory_defaults();

            [XmlRpcMethod("update")]
            void update(string short_id, string long_id);

            [XmlRpcMethod("clear_alarm_memory")]
            void clear_alarm_memory(string short_id, string long_id);

            [XmlRpcMethod("arm_away")]
            void arm_away(string short_id, string long_id, string down_code, string partition);

            [XmlRpcMethod("arm_home")]
            void arm_home(string short_id, string long_id, string down_code, string partition);

            [XmlRpcMethod("disarm")]
            void disarm(string short_id, string long_id, string down_code, string partition);

            [XmlRpcMethod("arm_instant")]
            void arm_instant(string short_id, string long_id, string down_code, string partition);

            [XmlRpcMethod("arm_latchkey")]
            void arm_latchkey(string short_id, string long_id, string down_code, string partition);

            [XmlRpcMethod("arm_quick")]
            void arm_quick(string short_id, string long_id, string down_code, string partition);

            [XmlRpcMethod("arm_home_quick")]
            void arm_home_quick(string short_id, string long_id, string down_code, string partition);

            [XmlRpcMethod("aux_button")]
            void aux_button(string short_id, string long_id);
                           
        }        
    }
}
