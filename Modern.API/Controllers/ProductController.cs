using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModernFindSearch.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Modern.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private List<Product> _products = new List<Product> {
new Product{ProductId = 1,ProductCode = "687882000",ProductDescription ="MSA GV551-0000000-000 VGARD 500 HELMET BLUE PUSH-KEY",SellPrice = 20.95},
new Product{ProductId = 2,ProductCode = "279013000",ProductDescription ="SAFETY CAP HARDCAP A1+ C/W 3CM MICRO PEAK BLACK",SellPrice = 20.04},
new Product{ProductId = 3,ProductCode = "689440000",ProductDescription ="DE LA RUE CONTRACTOR 1COL LRG TX386394U",SellPrice = 10.59},
new Product{ProductId = 4,ProductCode = "300476000",ProductDescription ="HAIRNET METAL FREE 5MM CLOSE MESH GREEN BAG OF 100",SellPrice = 20.15},
new Product{ProductId = 5,ProductCode = "300479000",ProductDescription ="HAIRNET METAL FREE 5MM CLOSE MESH YELLOW BAG OF 100",SellPrice = 20.15},
new Product{ProductId = 6,ProductCode = "300472000",ProductDescription ="HAIRNET METAL FREE 10MM COARSE MESH WHITE BAG OF 100",SellPrice = 17.97},
new Product{ProductId = 7,ProductCode = "492367000",ProductDescription ="BROWN SUGAR STICKS (BOX OF 1000)",SellPrice = 25.35},
new Product{ProductId = 8,ProductCode = "650540000",ProductDescription ="1005980 PERCAP REPLACEMENT PODS BOX (10 PAIRS) SNR24",SellPrice = 16.95},
new Product{ProductId = 9,ProductCode = "300227000",ProductDescription ="APRON PVC YELLOW 48\" x 36\" REF 4836YPBE",SellPrice = 8.48},
new Product{ProductId = 10,ProductCode = "300228000",ProductDescription ="APRON PVC BLUE 48\" x 36\" REF 4836BLPBE",SellPrice = 7.11},
new Product{ProductId = 11,ProductCode = "300231000",ProductDescription ="TAPE FOR APRONS 70M LONG 25MM WIDE ROLL BLUE PVC REF B29129",SellPrice = 12.83},
new Product{ProductId = 12,ProductCode = "740309000",ProductDescription ="BAG GYMSAC QUADRA SENIOR NAVY 49CM x 40CM           REF QD71",SellPrice = 5.46},
new Product{ProductId = 13,ProductCode = "462970000",ProductDescription ="Howard Leight 1011145 [10] Clarity C2 Earmuffs SNR 30",SellPrice = 160.37},
new Product{ProductId = 14,ProductCode = "873486000",ProductDescription ="HEATED SEAT COVERS B-WARMS",SellPrice = 94.72},
new Product{ProductId = 15,ProductCode = "873487000",ProductDescription ="DOUBLE HEATED MATRESS COVER REF 48002",SellPrice = 47.28},
new Product{ProductId = 16,ProductCode = "873488000",ProductDescription ="3.5 LTR CORDED KETTLE IGENIX REF IG4350 CSP",SellPrice = 50.69},
new Product{ProductId = 17,ProductCode = "873489000",ProductDescription ="SINGLE HEATED MATRESS COVER REF PE109",SellPrice = 22.56},
new Product{ProductId = 18,ProductCode = "873490000",ProductDescription ="THERMAL BLANKET REF GD100 ROYAL BLUE",SellPrice = 14.01},
new Product{ProductId = 19,ProductCode = "292211000",ProductDescription ="KNEE PADS GEL COMFORT PER PAIR",SellPrice = 50.27},
new Product{ProductId = 20,ProductCode = "462971000",ProductDescription ="Uvex 9302-255 [5] Ultrasonic Goggle Spare Lenses",SellPrice = 33.55},
new Product{ProductId = 21,ProductCode = "254471000",ProductDescription ="TORCH VARTA WIND-UP SELF-CHARGE NO BATTERIES",SellPrice = 16.03},
new Product{ProductId = 22,ProductCode = "539217000",ProductDescription ="3749 SCOTT MULIFOLD HAND TOWELS WHITE 1 PLY WHITE [4000]",SellPrice = 32.05},
new Product{ProductId = 23,ProductCode = "271434000",ProductDescription ="HELMET CONCEPT WHITE S09WF GREEN X FRONT/BENTLEY SIDES LOGOS",SellPrice = 22.76},
new Product{ProductId = 24,ProductCode = "271437000",ProductDescription ="HELMET CONCEPT REDUCED PEAK WHITE S08WF C/W BENTLEY LOGO",SellPrice = 20.47},
new Product{ProductId = 25,ProductCode = "249173000",ProductDescription ="BADGE TRANSFER TRIMAX BACK BAM & LOGO 250MM x 71MM TX302378U",SellPrice = 1.05},
new Product{ProductId = 26,ProductCode = "249174000",ProductDescription ="BADGE TRANSFR TRIMAX FRONT BAM & LOGO 115MM x 33MM TX302379U",SellPrice = 0.59},
new Product{ProductId = 27,ProductCode = "492376000",ProductDescription ="W378 BEANIE HAT BOTTLE GREEN",SellPrice = 5.32},
new Product{ProductId = 28,ProductCode = "462976000",ProductDescription ="26180 STOKO VARIO ULTRA BLACK OR WHITE DISPENSER",SellPrice = 14.26},
new Product{ProductId = 29,ProductCode = "492377000",ProductDescription ="W378 BEANIE HAT BOTTLE GREEN + INTERSERVE EMB. 00007393",SellPrice = 5.15},
new Product{ProductId = 30,ProductCode = "271136000",ProductDescription ="HELMET SAFETY HC600V WHITE C/W HXSPEC VISOR & GRACELAND LOGO",SellPrice = 26.2},
new Product{ProductId = 31,ProductCode = "254085000",ProductDescription ="EAR PLUG HOWARD LEIGHT FUSION DETECTABLE CORDED PAIR SNR 28",SellPrice = 2.16},
new Product{ProductId = 32,ProductCode = "530031000",ProductDescription ="GRAFFITI REMOVER ACTIVATOR 1 LTR CASE OF 12",SellPrice = 133},
new Product{ProductId = 33,ProductCode = "530033000",ProductDescription ="REMOVER CHEWING GUM DELTA DP200 LIQUID 1 LTR CASE/12 1DP",SellPrice = 133},
new Product{ProductId = 34,ProductCode = "546655000",ProductDescription ="EVERBUILD DECORATORS FILLER WHITE",SellPrice = 1.32},
new Product{ProductId = 35,ProductCode = "546678000",ProductDescription ="EVERBUILD GAP FILLING EXPANDING FOAM 750ML",SellPrice = 6.95},
new Product{ProductId = 36,ProductCode = "546683000",ProductDescription ="EVERBUILD INSTANT NAILS C3",SellPrice = 3.57},
new Product{ProductId = 37,ProductCode = "272134000",ProductDescription ="HELMET SAFETY CENTURION 1125 S03W WHITE C/W BAM NUTTALL LOGO",SellPrice = 15.83},
new Product{ProductId = 38,ProductCode = "249190000",ProductDescription ="BADGE TRIMAX BALFOUR BEATTY BACK 235MM x 125MM REF TX313852U",SellPrice = 1.37},
new Product{ProductId = 39,ProductCode = "292752000",ProductDescription ="BATTERY FOR PUREFLO HELMET REF PRO1030SP",SellPrice = 84.54},
new Product{ProductId = 40,ProductCode = "292753000",ProductDescription ="FILTER HIGH EFFICIENCY P3 FOR PUREFLO HELMET REF PRO1020SP",SellPrice = 34.74},
new Product{ProductId = 41,ProductCode = "548903000",ProductDescription ="CLEANER DISINFECT SANI DES QUATTRO SELECT 2.5LTRS CASE OF 2",SellPrice = 94.66},
new Product{ProductId = 42,ProductCode = "548904000",ProductDescription ="CLEANER FLOOR SPRINT 200 QUATTRO SELECT 2.5LTRS CASE OF 2",SellPrice = 75.3},
new Product{ProductId = 43,ProductCode = "548909000",ProductDescription ="CLEANER FLOOR TASKI JONTEC FORWARD QS 2X2.5LTR (CSP)",SellPrice = 100.71},
new Product{ProductId = 44,ProductCode = "548905000",ProductDescription ="CLEANER GLASS SPRINT GLASS QUATTRO SELECT 2.5LTRS CASE OF 2",SellPrice = 126.4},
new Product{ProductId = 45,ProductCode = "548906000",ProductDescription ="CLEANER HARD SURFACE SPRINT EMEREL QUATTRO SELECT 2X2.5L",SellPrice = 120.71},
new Product{ProductId = 46,ProductCode = "548907000",ProductDescription ="FRESHENER AIR GOOD SENSE VERT QUATTRO SELECT 2.5LTRS CASE 2",SellPrice = 149.99},
new Product{ProductId = 47,ProductCode = "548908000",ProductDescription ="CLEANER FLOOR JONTEC 300 QUATTRO SELECT 2.5LTRS CASE OF 2",SellPrice = 80.67},
new Product{ProductId = 48,ProductCode = "462981000",ProductDescription ="HC300VEL [40] WHITE C/W SHERLOCK LOGO BR8599",SellPrice = 367.19},
new Product{ProductId = 49,ProductCode = "492381000",ProductDescription ="MIDLAND METRO ALLIANCE SITE INDUCTION HELMET STICKER",SellPrice = 0.29},
new Product{ProductId = 50,ProductCode = "492382000",ProductDescription ="POLYGARD BRAKE & CLUTCH CLEANER 5LTR",SellPrice = 19.73},
new Product{ProductId = 51,ProductCode = "539084000",ProductDescription ="HYGI WIPES 01 PLUS DISPOSABLE HCL56 BZF (6 X 50) CLOTHS BLUE",SellPrice = 15.69},
new Product{ProductId = 52,ProductCode = "744096000",ProductDescription ="PADLOCK COMBINATION SQUIRE STRONGHOLD FIVE WHEEL 75MM SHCB75",SellPrice = 53.92},
new Product{ProductId = 53,ProductCode = "492383000",ProductDescription ="ECO CURE CONCRETE CURING COMPOUND 25LTR",SellPrice = 59},
new Product{ProductId = 54,ProductCode = "466184000",ProductDescription ="4836BLPBE 48x36\" Blue Heavyweight PVC Bib Apron",SellPrice = 5.19},
new Product{ProductId = 55,ProductCode = "580427000",ProductDescription ="VACUUM CLEANER CLEANGENIE 1200W BLUE REF BF 511",SellPrice = 114.57},
new Product{ProductId = 56,ProductCode = "580428000",ProductDescription ="VACUUM CLEANER CLEANGENIE 1200W GREEN REF BF512A",SellPrice = 148.94},
new Product{ProductId = 57,ProductCode = "292754000",ProductDescription ="VISOR ASSEMBLY FOR PUREFLO HELMET REF PRO1050SP",SellPrice = 350.57},
new Product{ProductId = 58,ProductCode = "292756000",ProductDescription ="SPARK SHIELD NECK CAPE FOR PUREFLO HELMET      REF PRO1105SP",SellPrice = 53.49},
new Product{ProductId = 59,ProductCode = "462982000",ProductDescription ="Centurion S28 [Green] Standard Peak Cool Cap",SellPrice = 16.67},
new Product{ProductId = 60,ProductCode = "462983000",ProductDescription ="S12 PLUSHVYR [20] WHITE REFLEX C/W RATCHET",SellPrice = 323.13},
new Product{ProductId = 61,ProductCode = "462984000",ProductDescription ="BST67NFW SHOWA NITTY GRITTY GLOVE SIZE 10",SellPrice = 8.78},
new Product{ProductId = 62,ProductCode = "508280000",ProductDescription ="CLEANER FLOOR TASKI JONTEC 300NC CONC 1LTR CASE OF 6 7515077",SellPrice = 79.81},
new Product{ProductId = 63,ProductCode = "508553000",ProductDescription ="7415 WYPALL L10 WIPER  2PLY WHITE ROLL 200 SHT [6]",SellPrice = 42.72},
new Product{ProductId = 64,ProductCode = "254468000",ProductDescription ="RADIO 2-WAY MOTOROLA BUSINESS TWINPACK 2 HANDSETS NOW XT180",SellPrice = 129.62},
new Product{ProductId = 65,ProductCode = "250122000",ProductDescription ="LOGO HEATSEAL KOLORMAX MORAY COUNCIL 50MM x 58MM CP420168U",SellPrice = 1.58},
new Product{ProductId = 66,ProductCode = "516113000",ProductDescription ="CLEANER SOLVENT EVERFLEX PVCu 1LITRE CONTAINER REF PVCS1 CSP",SellPrice = 13.71},
new Product{ProductId = 67,ProductCode = "702007000",ProductDescription ="BIN GRIT/SALT 6 CUBIC FOOT BLACK BASE YELLOW LID",SellPrice = 136.74},
new Product{ProductId = 68,ProductCode = "548140000",ProductDescription ="SOAP PRISTINE HAND FOAM LEMON 1 LITRE CARTRIDGE",SellPrice = 9.36},
new Product{ProductId = 69,ProductCode = "548141000",ProductDescription ="SOAP PRISTINE HEAVY DUTY CITRUS 2 LITRE CARTRIDGE",SellPrice = 9.53},
new Product{ProductId = 70,ProductCode = "548142000",ProductDescription ="CREAM PRISTINE AFTER WORK RESTORE 1 LITRE CARTRIDGE",SellPrice = 16.53},
new Product{ProductId = 71,ProductCode = "548143000",ProductDescription ="CREAM PRISTINE PRE WORK PROTECT 1 LITRE CARTRIDGE",SellPrice = 15.35},
new Product{ProductId = 72,ProductCode = "548144000",ProductDescription ="DISPENSER PRISTINE FOR 2 LITRE HEAVY DUTY SOAP CARTRIDGE",SellPrice = 5.95},
new Product{ProductId = 73,ProductCode = "548145000",ProductDescription ="DISPENSER PRISTINE FOR 1 LITRE HAND FOAM SOAP CARTRIDGE",SellPrice = 5.95},
new Product{ProductId = 74,ProductCode = "548146000",ProductDescription ="DISPENSER PRISTINE FOR 1 LITRE PRE-WORK PROTECT CARTRIDGE",SellPrice = 5.95},
new Product{ProductId = 75,ProductCode = "548147000",ProductDescription ="DISPENSER PRISTINE FOR 1 LITRE AFTER-WORK RESTORE CARTRIDGE",SellPrice = 5.95},
new Product{ProductId = 76,ProductCode = "000999000",ProductDescription ="CATALOGUE GREENHAM EXTENDED RANGE ANNUAL ISSUE SKU COUNT ONL",SellPrice = 0.02},
new Product{ProductId = 77,ProductCode = "462985000",ProductDescription ="UH-579381009 HUSQ TECH CHAINSAW GLV",SellPrice = 52.99},
new Product{ProductId = 78,ProductCode = "343284000",ProductDescription ="WORKER EMERGENCY ID STICKER SIZE 7CM X 1.5CM CODE WS1DO1",SellPrice = 4.67},
new Product{ProductId = 79,ProductCode = "710076000",ProductDescription ="DE-ICER SUPER PROFESSIONAL 750ML TRIGGER SPRAY",SellPrice = 4.54},
new Product{ProductId = 80,ProductCode = "724313000",ProductDescription ="HAMMER SLEDGE C/W FIBREGLASS HANDLE SPARTAN PRO 4.5KG/10LB",SellPrice = 37.87},
new Product{ProductId = 81,ProductCode = "724045000",ProductDescription ="HAMMER CLAW ONE PIECE STEEL SHAFT SPARTAN PRO 0.45KG/16OZ",SellPrice = 20.27},
new Product{ProductId = 82,ProductCode = "746869000",ProductDescription ="SCREWDRIVER SET 9 PIECE IN PLASTIC CASE SPARTAN PRO",SellPrice = 27.02},
new Product{ProductId = 83,ProductCode = "742886000",ProductDescription ="PLIERS 3 PIECE SET IN CANVAS CARRYING CASE SPARTAN PRO",SellPrice = 33.06},
new Product{ProductId = 84,ProductCode = "724201000",ProductDescription ="HAMMER SCALING/CHIPPING C/W FIBREGLASS HANDLE 0.45KG/16OZ",SellPrice = 11.12},
new Product{ProductId = 85,ProductCode = "531010000",ProductDescription ="FABRIC REFRESHER FEBREZE CLASSIC 500ML TRIGGER",SellPrice = 8.48},
new Product{ProductId = 86,ProductCode = "271098000",ProductDescription ="HELMET REFLEX WHITE/YELL FLASH S12WHVYAP BARRATT LONDON LOGO",SellPrice = 16.6},
new Product{ProductId = 87,ProductCode = "706026000",ProductDescription ="CROWBAR - SPARTAN PRO DEMOLITION BAR SET OF 3 (14,24 & 36\")",SellPrice = 27.34},
new Product{ProductId = 88,ProductCode = "292107000",ProductDescription ="SPECTACLE SAFETY-JACKSON SAFETY V30 VL NEMESIS CLEAR 25701",SellPrice = 5.21},
new Product{ProductId = 89,ProductCode = "462988000",ProductDescription ="Honeywell 1002221 Armamax AX1H Clear Eyeshield [10]",SellPrice = 50.46},
new Product{ProductId = 90,ProductCode = "740533000",ProductDescription ="LEVEL SPIRIT BOX ALUMINIUM THREE VIAL SPARTAN PRO 900MM/36\"",SellPrice = 16.83},
new Product{ProductId = 91,ProductCode = "740560000",ProductDescription ="LEVEL SPIRIT HEAVY DUTY ALUMINIUM SPARTAN PRO 600MM/24\"",SellPrice = 27.68},
new Product{ProductId = 92,ProductCode = "740561000",ProductDescription ="LEVEL SPIRIT HEAVY DUTY ALUMINIUM SPARTAN PRO 1200MM/48\"",SellPrice = 45.71},
new Product{ProductId = 93,ProductCode = "740562000",ProductDescription ="LEVEL SPIRIT HEAVY DUTY ALUMINIUM SPARTAN PRO 1800MM/72\"",SellPrice = 66.33},
new Product{ProductId = 94,ProductCode = "766449000",ProductDescription ="WHEEL ROAD MEASURING C/W CARRY BAG SPARTAN PRO",SellPrice = 132.94},
new Product{ProductId = 95,ProductCode = "230067000",ProductDescription ="CABLE TIE BLACK PLASTIC ASSORTED DRUM OF 300",SellPrice = 2.2},
new Product{ProductId = 96,ProductCode = "292110000",ProductDescription ="SPECTACLE SAFETY-JACKSON SAFETY V60 NEMESIS RX CLEAR 2.0",SellPrice = 6.67},
new Product{ProductId = 97,ProductCode = "292111000",ProductDescription ="SPECTACLE SAFETY-JACKSON SAFETY V60 NEMESIS RX CLEAR 2.5",SellPrice = 6.67},
new Product{ProductId = 98,ProductCode = "466189000",ProductDescription ="67540 BULKYSOFT 2PLY WHITE INTERFOLD TOILET TISSUE",SellPrice = 38.73},
new Product{ProductId = 99,ProductCode = "689752000",ProductDescription ="SAFETY CHAMPS BASF 6COL (2015)TX373661U",SellPrice = 2.09},
new Product{ProductId = 100,ProductCode = "466190000",ProductDescription ="1110 BULKYSOFT TOILET TISSUE DISPENSER - FOC",SellPrice = 0.01},
new Product{ProductId = 101,ProductCode = "292113000",ProductDescription ="SPECTACLE SAFETY-JACKSON SAFETY V10 UNISPEC 11 CLEAR 25646",SellPrice = 2.08},
new Product{ProductId = 102,ProductCode = "292114000",ProductDescription ="SPECTACLE SAFETY-JACKSON SAFETY V20 PURITY CLEAR REF 25654",SellPrice = 4.13},
new Product{ProductId = 103,ProductCode = "466191000",ProductDescription ="Bulky Soft 84500 Classic 2ply V-fold Hand Towel [20x200]",SellPrice = 41.28},
new Product{ProductId = 104,ProductCode = "466192000",ProductDescription ="1010 BULKYSOFT HAND TOWEL DISPENSER - FOC",SellPrice = 0.01},
new Product{ProductId = 105,ProductCode = "469772000",ProductDescription ="Portwest A689GRR 14\" Grey Cut Resistant Sleeves",SellPrice = 9.78},
new Product{ProductId = 106,ProductCode = "660802000",ProductDescription ="VETTER (VETTER LOGO ONLY) LRG 2 COL TX597724U",SellPrice = 10},
new Product{ProductId = 107,ProductCode = "204049000",ProductDescription ="CONE DEMARCATION 1 METRE YELLOW           REF JAT070-040-200",SellPrice = 19.24},
new Product{ProductId = 108,ProductCode = "582150000",ProductDescription ="WIPER WYPALL BLUE L20 152M CENTREFEED ROLL CASE 6 KC7267//",SellPrice = 42.43},
new Product{ProductId = 109,ProductCode = "582151000",ProductDescription ="7268 WYPALL L10 EXTRA WIPERS C/FEED ROLL WHITE 400 SHT [6]",SellPrice = 42.43},
new Product{ProductId = 110,ProductCode = "548396000",ProductDescription ="SANITISER HAND DEB INSTANTFOAM 1 LITRE CARTRIDGE IFS1LTFEN",SellPrice = 19.3},
new Product{ProductId = 111,ProductCode = "650407000",ProductDescription ="BP2900RC PRISTINE BULK PACK 2PLY WHITE (9000 SHEETS)",SellPrice = 23.69},
new Product{ProductId = 112,ProductCode = "249146000",ProductDescription ="BADGE TRANSFER TRIMAX BUNZL FRONT 50MM x 51MM  REF TX263574U",SellPrice = 0.8},
new Product{ProductId = 113,ProductCode = "548394000",ProductDescription ="DISPENSER TOUCH FREE FOR 1LITRE DEB INSTANTFOAM REF IFSTF2EN",SellPrice = 59.41},
new Product{ProductId = 114,ProductCode = "688110000",ProductDescription ="MARKS & SPENCER £25 VOUCHER",SellPrice = 25.5},
new Product{ProductId = 115,ProductCode = "689020000",ProductDescription ="SKYTEC OHIO HPT FOAM PALM COATED SIZE 8 (CUT 1)SEE 659023",SellPrice = 4.05},
new Product{ProductId = 116,ProductCode = "689021000",ProductDescription ="SKYTEC OHIO HPT FOAM PALM COATED SIZE 9 (CUT 1)SEE 659023",SellPrice = 4.05},
new Product{ProductId = 117,ProductCode = "689022000",ProductDescription ="SKYTEC OHIO HPT FOAM PALM COATED SIZE 10 (CUT 1)SEE 659023",SellPrice = 4.05},
new Product{ProductId = 118,ProductCode = "508266000",ProductDescription ="SCREEN WASH PROFESSIONAL READY TO USE 5 LITRE",SellPrice = 4.32},
new Product{ProductId = 119,ProductCode = "650757000",ProductDescription ="CONSIDERATE CONSTRUCTORS ASSOCIATE 3 COL SMALL TX424459U",SellPrice = 10.59},
new Product{ProductId = 120,ProductCode = "688561000",ProductDescription ="SPECS KEEPSAFE PHANTOM CLEAR LENS 293150",SellPrice = 3.44},
new Product{ProductId = 121,ProductCode = "250236000",ProductDescription ="SIGN RIGID PLASTIC 450X150MM - FIRE EXIT ARROW RIGHT  12004L",SellPrice = 11.24},
new Product{ProductId = 122,ProductCode = "250237000",ProductDescription ="SIGN RIGID PLASTIC 450X150MM - FIRE EXIT ARROW LEFT   12003L",SellPrice = 11.24},
new Product{ProductId = 123,ProductCode = "660803000",ProductDescription ="FIRE AUXILIARY WHITE HELMET STICKER (GREENHAM) HE614748U",SellPrice = 10},
new Product{ProductId = 124,ProductCode = "746647000",ProductDescription ="BLACK WHEELIE BIN LINER 26x47x53 (CS144)",SellPrice = 53.46},
new Product{ProductId = 125,ProductCode = "203013000",ProductDescription ="SAFETY GOAL POST SYSTEM SGPS01",SellPrice = 636.53},
new Product{ProductId = 126,ProductCode = "304358000",ProductDescription ="GAUNTLET HEAT RESISTANT ANSELL WORKGUARD 410MM REF 43-216",SellPrice = 14.33},
new Product{ProductId = 127,ProductCode = "250247000",ProductDescription ="SIGN RIGID PLASTIC 300X250MM - FIRE ASSEMBLY POINT    12059H",SellPrice = 12.94},
new Product{ProductId = 128,ProductCode = "462994000",ProductDescription ="Uvex 60491 C500 Green Cut 5 40cm Sleeves[10] *use 471263",SellPrice = 127.15},
new Product{ProductId = 129,ProductCode = "462995000",ProductDescription ="Scott HC300VEL Style 300 Elite [Green] [20] Helmets",SellPrice = 176.9},
new Product{ProductId = 130,ProductCode = "463000000",ProductDescription ="HELMET SAFETY APEX MICRO PEAK RATCHET A05 WHITE",SellPrice = 25.44},
new Product{ProductId = 131,ProductCode = "254821000",ProductDescription ="WIPES ANTIBAC W805110PT CASE OF 200",SellPrice = 5.19},
new Product{ProductId = 132,ProductCode = "650337000",ProductDescription ="DRAGER X-PLORE 4340 R54275 HALF MASK SIZE S/M",SellPrice = 29.95},
new Product{ProductId = 133,ProductCode = "702387000",ProductDescription ="HELPING HANDS HANDY LOOP LP0010",SellPrice = 18.77},
new Product{ProductId = 134,ProductCode = "466194000",ProductDescription ="Norths A150275 Vortex Air Conditioner",SellPrice = 127.69},
new Product{ProductId = 135,ProductCode = "466195000",ProductDescription ="Norths A114400 Junior B VL Lightweight Cape",SellPrice = 211.42},
new Product{ProductId = 136,ProductCode = "660341000",ProductDescription ="HPC (UKPN) SMALL 3COL TX512562U",SellPrice = 10},
new Product{ProductId = 137,ProductCode = "660342000",ProductDescription ="BUILDING BETTER ENERGY (UKPN) SMALL 1COL WHITE TX511283U",SellPrice = 10.39},
new Product{ProductId = 138,ProductCode = "660343000",ProductDescription ="BUILDING BETTER ENERGY (UKPN) LARGE 1COL WHITE TX511286U",SellPrice = 10.39},
new Product{ProductId = 139,ProductCode = "660344000",ProductDescription ="HPC UKPN SERVICES LARGE 3COL WHITE TX512108U",SellPrice = 10.39},
new Product{ProductId = 140,ProductCode = "660345000",ProductDescription ="HPC UKPN SERVICES XL 4COL BLACK TX512110U",SellPrice = 10.39},
new Product{ProductId = 141,ProductCode = "660346000",ProductDescription ="BUILDING BETTER ENERGY LARGE 1COL BLUE TX461410U",SellPrice = 10},
new Product{ProductId = 142,ProductCode = "463001000",ProductDescription ="WINTER HELMET LINER NAVY BLUE SZHL",SellPrice = 17.28},
new Product{ProductId = 143,ProductCode = "463002000",ProductDescription ="EARZ BLACK HELMET EARMUFF SNR31DB HEM31",SellPrice = 37.7},
new Product{ProductId = 144,ProductCode = "650116000",ProductDescription ="DRYWALL SOLUTIONS NEW LRG 1COL TX411282U",SellPrice = 10.79},
new Product{ProductId = 145,ProductCode = "018989000",ProductDescription ="BLACK BALACLAVA FR / AS / ARC FR18",SellPrice = 19.03},
new Product{ProductId = 146,ProductCode = "271449000",ProductDescription ="HELMET CONCEPT WHITE C/W WSP LOGO S09WF WSP5 (CSP)",SellPrice = 15},
new Product{ProductId = 147,ProductCode = "539200000",ProductDescription ="TISSUE TOILET JUMBO SCOTT 2PLY 6 x 350 METRES KC8625",SellPrice = 52.84},
new Product{ProductId = 148,ProductCode = "766412000",ProductDescription ="DISC CUTTING PCD FIBRE BOARD 160X 20",SellPrice = 62.5},
new Product{ProductId = 149,ProductCode = "766413000",ProductDescription ="DISC CUTTING PCD FIBRE BOARD 184 X 30",SellPrice = 66.19},
new Product{ProductId = 150,ProductCode = "650338000",ProductDescription ="DRAGER X-PLORE 4340 R54270 HALF MASK SIZE M/L",SellPrice = 29.95},
new Product{ProductId = 151,ProductCode = "463003000",ProductDescription ="HELMET EARMUFF SNR27 EN352-3 HEM27",SellPrice = 18.74},
new Product{ProductId = 152,ProductCode = "463004000",ProductDescription ="APEX DELUXE BROWGUARD RATCHET FITS APC8V ABG",SellPrice = 11.52},
new Product{ProductId = 153,ProductCode = "463005000",ProductDescription ="APEX + SAFETY SOURCE HELMET INC TERYLENE HARNESS A02 BLUE",SellPrice = 15.1},
new Product{ProductId = 154,ProductCode = "650342000",ProductDescription ="8101961 GAS DETECTOR TUBE 2/B HYDROGEN SULPHIDE  (BOX 10)",SellPrice = 109.58},
new Product{ProductId = 155,ProductCode = "650343000",ProductDescription ="CH30701 GAS DETECTOR TUBE 10/B PERCHLOROETHYLENE (BOX 10)",SellPrice = 119.33},
new Product{ProductId = 156,ProductCode = "469777000",ProductDescription ="Pulsar PR503 Hi-Viz Orange Overtrousers 4XL ONLY",SellPrice = 150},
new Product{ProductId = 157,ProductCode = "650344000",ProductDescription ="6728541 GAS DETECTOR TUBE 2/A TRICHLOROETHYLENE (BOX 10)",SellPrice = 113.49},
new Product{ProductId = 158,ProductCode = "687709000",ProductDescription ="TURTON WINTER WARMERS BROCHURE 2013/14 (PACK 50)",SellPrice = 10.79},
new Product{ProductId = 159,ProductCode = "469778000",ProductDescription ="Moldex 7232 Half Mask & A2P3 Filters Pre-Assembled [4]",SellPrice = 200},
new Product{ProductId = 160,ProductCode = "689034000",ProductDescription ="3M S-655 VERSAFLO S-SERIES WHITE HOOD WITH INNER COLLAR",SellPrice = 214.68},
new Product{ProductId = 161,ProductCode = "650345000",ProductDescription ="8101661 GAS DETECTOR TUBE 5/B TOLUENE (BOX 10)",SellPrice = 135.21},
new Product{ProductId = 162,ProductCode = "650346000",ProductDescription ="8101811 GAS DETECTOR TUBE 100/A CARBON DIOXIDE (BOX 10)",SellPrice = 106.55},
new Product{ProductId = 163,ProductCode = "650347000",ProductDescription ="6733051 GAS DETECTOR TUBE 2/A CARBON MONOXIDE (BOX 10)",SellPrice = 127.37},
new Product{ProductId = 164,ProductCode = "650348000",ProductDescription ="6728781 GAS DETECTION TUBE SULPHURIC ACID 0.1/A (PACK 9)",SellPrice = 179.59},
new Product{ProductId = 165,ProductCode = "650349000",ProductDescription ="DRAEGER 673879 MULTI FILTER A2B2E2K2 Hg-P3 TH/M3 ABEK2 PSLR",SellPrice = 30.72},
new Product{ProductId = 166,ProductCode = "650760000",ProductDescription ="BARKER MORRIS SMALL WHITE TX404110U",SellPrice = 10.79},
new Product{ProductId = 167,ProductCode = "469783000",ProductDescription ="Portwest P251 FFP2 valved fold flat respirator [20] - white",SellPrice = 85},
new Product{ProductId = 168,ProductCode = "660301000",ProductDescription ="TOILET PORTABLE/DISPOSABLE URINAL TRAVEL JOHN PACK OF 3 //",SellPrice = 5.86},
new Product{ProductId = 169,ProductCode = "492446000",ProductDescription ="PR750 PLAIN SATIN TIE TURQUOISE",SellPrice = 13.64},
new Product{ProductId = 170,ProductCode = "492447000",ProductDescription ="PR470 PLAIN CHIFFON TIE TURQUOISE",SellPrice = 13.64},
new Product{ProductId = 171,ProductCode = "650408000",ProductDescription ="DS926E PRISTINE BULK PACK DISPENCER WHITE",SellPrice = 21.49},
new Product{ProductId = 172,ProductCode = "463006000",ProductDescription ="APEX + SAFETY SOURCE HELMET INC TERYLENE HARNESS A02 YELLOW",SellPrice = 12.7},
new Product{ProductId = 173,ProductCode = "463014000",ProductDescription ="EARZ SILICONE CORDED (SOPR) EARPLUGS SNR29 EPSC29",SellPrice = 40.8},
new Product{ProductId = 174,ProductCode = "463007000",ProductDescription ="APEX + SAFETY SOURCE HELMET INC TERYLENE HARNESS A02 RED",SellPrice = 12.88},
new Product{ProductId = 175,ProductCode = "463008000",ProductDescription ="HELMET AERO SHORTPEAK COMFORT CRADLE+AVS A03 WHITE",SellPrice = 13.36},
new Product{ProductId = 176,ProductCode = "687822000",ProductDescription ="LOR/MISSION ZERO LRG 4COL TX372986U",SellPrice = 10},
new Product{ProductId = 177,ProductCode = "687823000",ProductDescription ="CHT CROWN HS/MISSION ZERO LRG 5COL TX372991U",SellPrice = 10.79},
new Product{ProductId = 178,ProductCode = "687824000",ProductDescription ="VETTER/MISSION ZERO LARGE 3COL TX372990U",SellPrice = 10.79},
new Product{ProductId = 179,ProductCode = "687825000",ProductDescription ="SELECT/MISSION ZERO LRG 4COL TX372993U",SellPrice = 3.19},
new Product{ProductId = 180,ProductCode = "687826000",ProductDescription ="EXPLORE MANF/MISSION ZERO 5COL LARGE TX374820U",SellPrice = 10.59},
new Product{ProductId = 181,ProductCode = "254623000",ProductDescription ="PLATE OUTER COVER PACK OF 10 REF 526000",SellPrice = 27.56},
new Product{ProductId = 182,ProductCode = "254624000",ProductDescription ="PLATE INNER COVER PACK OF 5 REF 528025",SellPrice = 16.24},
new Product{ProductId = 183,ProductCode = "254614000",ProductDescription ="PLATE FX PLATE COVER HOLDER PACK 5 REF 523000",SellPrice = 43.94},
new Product{ProductId = 184,ProductCode = "254615000",ProductDescription ="FACE SEAL 9100 FX AIR 3M SPEEDGLAS REF 534000",SellPrice = 56.76},
new Product{ProductId = 185,ProductCode = "900004000",ProductDescription ="DUSTPAN LOBBY GREY/BLACK SILVER HANDLE",SellPrice = 17.6},
new Product{ProductId = 186,ProductCode = "900005000",ProductDescription ="BRUSH LOBBY BLACK - FOR USE WITH DUSTPAN 900004",SellPrice = 10.5},
new Product{ProductId = 187,ProductCode = "290034000",ProductDescription ="RESPIRATOR DISPOSABLE TARGET FFP2 VALVED BOX 10 EN149:2001",SellPrice = 18.64},
new Product{ProductId = 188,ProductCode = "290035000",ProductDescription ="RESPIRATOR DISPOSABLE TARGET FFP3 VALVED BOX OF 5 EN149:2001",SellPrice = 37.28},
new Product{ProductId = 189,ProductCode = "293021000",ProductDescription ="SPECTACLE SAFETY BOLLE SLAM CLEAR LENS",SellPrice = 8.03},
new Product{ProductId = 190,ProductCode = "293022000",ProductDescription ="BOLLE SAFETY SPEC RUSHPSI CLEAR PC LENS AS/AF",SellPrice = 5.6},
new Product{ProductId = 191,ProductCode = "689590000",ProductDescription ="EXPRESS HEATING 1 COL RED SMALL TX398032U",SellPrice = 5.39},
new Product{ProductId = 192,ProductCode = "689591000",ProductDescription ="EXPRESS HEATING 1 COL RED LARGE TX398031U",SellPrice = 5.39},
new Product{ProductId = 193,ProductCode = "463009000",ProductDescription ="AERO SHORTPEAK HELMET COMFORT CRADLE+AVS A03 BLACK",SellPrice = 13.37},
new Product{ProductId = 194,ProductCode = "254813000",ProductDescription ="FIRST AID-INTEGRAL AURA DISPENSER BOX BS8599 SMALL KIT",SellPrice = 62.26},
new Product{ProductId = 195,ProductCode = "254814000",ProductDescription ="FIRST AID - INTEGRAL AURA DISPENSER BOX BS8599 MEDIUM KIT",SellPrice = 80.4},
new Product{ProductId = 196,ProductCode = "254815000",ProductDescription ="FIRST AID - INTEGRAL AURA DISPENSER BOX BS8599 LARGE KIT",SellPrice = 94.73},
new Product{ProductId = 197,ProductCode = "463010000",ProductDescription ="AERO HELMET SHORTPEAK COMFORT CRADLE + AVS A03 BLUE",SellPrice = 13.14},
new Product{ProductId = 198,ProductCode = "463011000",ProductDescription ="AERO SHORTPEAK HELMET COMFORT CRADLE+AVS A03 YELLOW",SellPrice = 13.37},
new Product{ProductId = 199,ProductCode = "293023000",ProductDescription ="BOLLE SAFETY SPEC RUSHPSF SMOKE PC LENS AS/AF",SellPrice = 6.44},
new Product{ProductId = 200,ProductCode = "293024000",ProductDescription ="BOLLE SAFETY SPEC RUSH TWILIGHT PC LENS AS/AF",SellPrice = 7.05}
        };

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get([FromQuery] string filter)
        {
            if(!string.IsNullOrWhiteSpace(filter))
            {
                return _products.Where(p => p.ProductDescription.Contains(filter));
            }
            
            return _products;
        }

        [HttpGet("search")]
        public IEnumerable<Product> Search([FromQuery(Name = "filter")] string filter)
        {
            var query = _products.Where(p => p.ProductDescription.Contains(filter));
            return query;
            }

        [HttpGet("{filter}")]
        public IEnumerable<Product> GetFilter(string filter)
        {
            var query = _products.Where(p => p.ProductDescription.Contains(filter));
            return query;
        }

        [HttpPost]
        public string Search([FromBody] ProductFilter productFilter)
        {
            var resultProductList = _products.Where(p => p.ProductDescription.ToLower().Contains(productFilter.ProductReference.ToLower()));
            //var returnString = new StringContent(JsonSerializer.Serialize(resultProductList), Encoding.UTF8, "application/json");
            var returnString = JsonSerializer.Serialize(resultProductList);
            return returnString;
        }
    }
}
