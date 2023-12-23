using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTNExercise.Tests
{
    internal class Constants
    {
        public static string VALID_JSON_OBJECT_LIST = "{\"flashType\":1,\"strikeTime\":1446760902668,\"latitude\":40.6505993,\"longitude\":-94.4184609,\"peakAmps\":-3870,\"reserved\":\"000\",\"icHeight\":18323,\"receivedTime\":1446760915182,\"numberOfSensors\":18,\"multiplicity\":8}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760902712,\"latitude\":40.6361602,\"longitude\":-94.4143559,\"peakAmps\":-5516,\"reserved\":\"000\",\"icHeight\":18589,\"receivedTime\":1446760915182,\"numberOfSensors\":19,\"multiplicity\":8}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760902723,\"latitude\":40.6796339,\"longitude\":-94.4536764,\"peakAmps\":2199,\"reserved\":\"000\",\"icHeight\":18412,\"receivedTime\":1446760915182,\"numberOfSensors\":13,\"multiplicity\":8}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760902739,\"latitude\":40.5947489,\"longitude\":-94.442556,\"peakAmps\":-5354,\"reserved\":\"000\",\"icHeight\":18995,\"receivedTime\":1446760915182,\"numberOfSensors\":16,\"multiplicity\":8}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760902849,\"latitude\":40.7174738,\"longitude\":-94.3584957,\"peakAmps\":2206,\"reserved\":\"000\",\"icHeight\":10858,\"receivedTime\":1446760915182,\"numberOfSensors\":12,\"multiplicity\":8}" + "\n" +
                                            "{\"flashType\":0,\"strikeTime\":1446760903799,\"latitude\":-7.8664,\"longitude\":-167.2578,\"peakAmps\":-73086,\"reserved\":\"000\",\"icHeight\":0,\"receivedTime\":1446760915182,\"numberOfSensors\":7,\"multiplicity\":1}" + "\n" +
                                            "{\"flashType\":0,\"strikeTime\":1446760903744,\"latitude\":2.1444,\"longitude\":-74.8735,\"peakAmps\":-52624,\"reserved\":\"000\",\"icHeight\":0,\"receivedTime\":1446760915182,\"numberOfSensors\":6,\"multiplicity\":1}" + "\n" +
                                            "{\"flashType\":0,\"strikeTime\":1446760903532,\"latitude\":-7.5741,\"longitude\":-57.8212,\"peakAmps\":20249,\"reserved\":\"000\",\"icHeight\":0,\"receivedTime\":1446760915182,\"numberOfSensors\":7,\"multiplicity\":1}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760902720,\"latitude\":8.8400666,\"longitude\":-12.7052625,\"peakAmps\":3363,\"reserved\":\"000\",\"icHeight\":18467,\"receivedTime\":1446760915182,\"numberOfSensors\":8,\"multiplicity\":3}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760902981,\"latitude\":8.8157531,\"longitude\":-12.7124132,\"peakAmps\":2204,\"reserved\":\"000\",\"icHeight\":15202,\"receivedTime\":1446760915182,\"numberOfSensors\":5,\"multiplicity\":3}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760903193,\"latitude\":8.8338584,\"longitude\":-12.7121907,\"peakAmps\":3252,\"reserved\":\"000\",\"icHeight\":16093,\"receivedTime\":1446760915182,\"numberOfSensors\":8,\"multiplicity\":3}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760903039,\"latitude\":8.7983704,\"longitude\":-11.5264578,\"peakAmps\":6651,\"reserved\":\"000\",\"icHeight\":15786,\"receivedTime\":1446760915185,\"numberOfSensors\":8,\"multiplicity\":9}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760903066,\"latitude\":8.799021,\"longitude\":-11.5279905,\"peakAmps\":8545,\"reserved\":\"000\",\"icHeight\":16240,\"receivedTime\":1446760915185,\"numberOfSensors\":9,\"multiplicity\":9}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760903094,\"latitude\":8.805932,\"longitude\":-11.5357161,\"peakAmps\":6024,\"reserved\":\"000\",\"icHeight\":11424,\"receivedTime\":1446760915185,\"numberOfSensors\":7,\"multiplicity\":9}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760903104,\"latitude\":8.8209942,\"longitude\":-11.53745,\"peakAmps\":3794,\"reserved\":\"000\",\"icHeight\":11913,\"receivedTime\":1446760915185,\"numberOfSensors\":6,\"multiplicity\":9}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760903220,\"latitude\":8.7592632,\"longitude\":-11.5006597,\"peakAmps\":-4929,\"reserved\":\"000\",\"icHeight\":11924,\"receivedTime\":1446760915185,\"numberOfSensors\":7,\"multiplicity\":9}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760903283,\"latitude\":8.8095397,\"longitude\":-11.5402505,\"peakAmps\":2064,\"reserved\":\"000\",\"icHeight\":18572,\"receivedTime\":1446760915185,\"numberOfSensors\":5,\"multiplicity\":9}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760903336,\"latitude\":8.8300325,\"longitude\":-11.5412475,\"peakAmps\":3816,\"reserved\":\"000\",\"icHeight\":15325,\"receivedTime\":1446760915185,\"numberOfSensors\":5,\"multiplicity\":9}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760903421,\"latitude\":8.7635766,\"longitude\":-11.5205273,\"peakAmps\":3117,\"reserved\":\"000\",\"icHeight\":15358,\"receivedTime\":1446760915185,\"numberOfSensors\":6,\"multiplicity\":9}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760903456,\"latitude\":8.7922214,\"longitude\":-11.5231654,\"peakAmps\":-5112,\"reserved\":\"000\",\"icHeight\":15946,\"receivedTime\":1446760915185,\"numberOfSensors\":5,\"multiplicity\":9}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760902974,\"latitude\":32.9862554,\"longitude\":-98.3471457,\"peakAmps\":1254,\"reserved\":\"000\",\"icHeight\":16459,\"receivedTime\":1446760915185,\"numberOfSensors\":14,\"multiplicity\":8}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760902976,\"latitude\":32.9905308,\"longitude\":-98.34038,\"peakAmps\":1700,\"reserved\":\"000\",\"icHeight\":17229,\"receivedTime\":1446760915185,\"numberOfSensors\":14,\"multiplicity\":8}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760902991,\"latitude\":32.9874335,\"longitude\":-98.3458777,\"peakAmps\":1822,\"reserved\":\"000\",\"icHeight\":9518,\"receivedTime\":1446760915185,\"numberOfSensors\":13,\"multiplicity\":8}" + "\n" +
                                            "{\"flashType\":1,\"strikeTime\":1446760903000,\"latitude\":32.9814573,\"longitude\":-98.3462809,\"peakAmps\":6868,\"reserved\":\"000\",\"icHeight\":9741,\"receivedTime\":1446760915185,\"numberOfSensors\":17,\"multiplicity\":8}";

        public static string VALID_JSON_ARRAY = @"[{""assetName"":""Mayer Park"",""quadKey"":""023112133002"",""assetOwner"":""02115""},
                                            {""assetName"":""Sunshine Wall"",""quadKey"":""023112133003"",""assetOwner"":""325""},
                                            {""assetName"":""Cruickshank Forge"",""quadKey"":""023112133000"",""assetOwner"":""313""},
                                            {""assetName"":""Syed Pines"",""quadKey"":""023112133001"",""assetOwner"":""259""}]";
    }
}
