﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSX39Mog
{
    class Constants
    {
        public static List<ComboItem<int>> Channels = new List<ComboItem<int>>()
            {
                new ComboItem<int> { Key = "Miku", Data = 0 },
                new ComboItem<int> { Key = "Instrument", Data = 1 },
                new ComboItem<int> { Key = "Drums", Data = 9 },
            };

        public static Dictionary<string, byte> Lyrics = new Dictionary<string, byte> {
                {"あ" , 0x00},
                {"い" , 0x01},
                {"う" , 0x02},
                {"え" , 0x03},
                {"お" , 0x04},

                {"か" , 0x05},
                {"き" , 0x06},
                {"く" , 0x07},
                {"け" , 0x08},
                {"こ" , 0x09},

                {"が" , 0x0A},
                {"ぎ" , 0x0B},
                {"ぐ" , 0x0C},
                {"げ" , 0x0D},
                {"ご" , 0x0E},

                {"きゃ" , 0x0F},
                {"きゅ" , 0x10},
                {"きょ" , 0x11},

                {"ぎゃ" , 0x12},
                {"ぎゅ" , 0x13},
                {"ぎょ" , 0x14},

                {"さ" , 0x15},
                {"すぃ" , 0x16},
                {"す" , 0x17},
                {"せ" , 0x18},
                {"そ" , 0x19},

                {"ざ" , 0x1A},
                {"ずぃ" , 0x1B},
                {"ず" , 0x1C},
                {"ぜ" , 0x1D},
                {"ぞ" , 0x1E},

                {"しゃ" , 0x1F},
                {"し" , 0x20},
                {"しゅ" , 0x21},
                {"しぇ" , 0x22},
                {"しょ" , 0x23},

                {"じゃ" , 0x24},
                {"じ" , 0x25},
                {"じゅ" , 0x26},
                {"じぇ" , 0x27},
                {"じょ" , 0x28},

                {"た" , 0x29},
                {"てぃ" , 0x2A},
                {"とぅ" , 0x2B},
                {"て" , 0x2C},
                {"と" , 0x2D},

                {"だ" , 0x2E},
                {"でぃ" , 0x2F},
                {"どぅ" , 0x30},
                {"で" , 0x31},
                {"ど" , 0x32},

                {"てゅ" , 0x33},
                {"でゅ" , 0x34},

                {"ちゃ" , 0x35},
                {"ち" , 0x36},
                {"ちゅ" , 0x37},
                {"ちぇ" , 0x38},
                {"ちょ" , 0x39},

                {"つぁ" , 0x3A},
                {"つぃ" , 0x3B},
                {"つ" , 0x3C},
                {"つぇ" , 0x3D},
                {"つぉ" , 0x3E},

                {"な" , 0x3F},
                {"に" , 0x40},
                {"ぬ" , 0x41},
                {"ね" , 0x42},
                {"の" , 0x43},

                {"にゃ" , 0x44},
                {"にゅ" , 0x45},
                {"にょ" , 0x46},

                {"は" , 0x47},
                {"ひ" , 0x48},
                {"ふ" , 0x49},
                {"へ" , 0x4A},
                {"ほ" , 0x4B},

                {"ば" , 0x4C},
                {"び" , 0x4D},
                {"ぶ" , 0x4E},
                {"べ" , 0x4F},
                {"ぼ" , 0x50},

                {"ぱ" , 0x51},
                {"ぴ" , 0x52},
                {"ぷ" , 0x53},
                {"ぺ" , 0x54},
                {"ぽ" , 0x55},

                {"ひゃ" , 0x56},
                {"ひゅ" , 0x57},
                {"ひょ" , 0x58},

                {"びゃ" , 0x59},
                {"びゅ" , 0x5A},
                {"びょ" , 0x5B},

                {"ぴゃ" , 0x5C},
                {"ぴゅ" , 0x5D},
                {"ぴょ" , 0x5E},

                {"ふぁ" , 0x5F},
                {"ふぃ" , 0x60},
                {"ふゅ" , 0x61},
                {"ふぇ" , 0x62},
                {"ふぉ" , 0x63},

                {"ま" , 0x64},
                {"み" , 0x65},
                {"む" , 0x66},
                {"め" , 0x67},
                {"も" , 0x68},

                {"みゃ" , 0x69},
                {"みゅ" , 0x6A},
                {"みょ" , 0x6B},

                {"や" , 0x6C},
                {"ゆ" , 0x6D},
                {"よ" , 0x6E},

                {"ら" , 0x6F},
                {"り" , 0x70},
                {"る" , 0x71},
                {"れ" , 0x72},
                {"ろ" , 0x73},

                {"りゃ" , 0x74},
                {"りゅ" , 0x75},
                {"りょ" , 0x76},

                {"わ" , 0x77},
                {"うぃ" , 0x78},
                {"うぇ" , 0x79},
                {"うぉ" , 0x7A},

                {"ん" , 0x7B},
                {"ん２" , 0x7C},
                {"ん３" , 0x7D},
                {"ん４" , 0x7E},
                {"ん５" , 0x7F}
            };

        public static List<string> Programs = new List<string> {
                "Acoustic Piano",
                "Bright Piano",
                "Electric Grand Piano",
                "Honky-tonk Piano",
                "Electric Piano",
                "Electric Piano 2",
                "Harpsichord",
                "Clavi",
                "Celesta",
                "Glockenspiel",
                "Musical box",
                "Vibraphone",
                "Marimba",
                "Xylophone",
                "Tubular Bell",
                "Dulcimer",
                "Drawbar Organ",
                "Percussive Organ",
                "Rock Organ",
                "Church organ",
                "Reed organ",
                "Accordion",
                "Harmonica",
                "Tango Accordion",
                "Acoustic Guitar (nylon)",
                "Acoustic Guitar (steel)",
                "Electric Guitar (jazz)",
                "Electric Guitar (clean)",
                "Electric Guitar (muted)",
                "Overdriven Guitar",
                "Distortion Guitar",
                "Guitar harmonics",
                "Acoustic Bass",
                "Electric Bass (finger)",
                "Electric Bass (pick)",
                "Fretless Bass",
                "Slap Bass 1",
                "Slap Bass 2",
                "Synth Bass 1",
                "Synth Bass 2",
                "Violin",
                "Viola",
                "Cello",
                "Double bass",
                "Tremolo Strings",
                "Pizzicato Strings",
                "Orchestral Harp",
                "Timpani",
                "String Ensemble 1",
                "String Ensemble 2",
                "Synth Strings 1",
                "Synth Strings 2",
                "Voice Aahs",
                "Voice Oohs",
                "Synth Voice",
                "Orchestra Hit",
                "Trumpet",
                "Trombone",
                "Tuba",
                "Muted Trumpet",
                "French horn",
                "Brass Section",
                "Synth Brass 1",
                "Synth Brass 2",
                "Soprano Sax",
                "Alto Sax",
                "Tenor Sax",
                "Baritone Sax",
                "Oboe",
                "English Horn",
                "Bassoon",
                "Clarinet",
                "Piccolo",
                "Flute",
                "Recorder",
                "Pan Flute",
                "Blown Bottle",
                "Shakuhachi",
                "Whistle",
                "Ocarina",
                "Lead 1 (square)",
                "Lead 2 (sawtooth)",
                "Lead 3 (calliope)",
                "Lead 4 (chiff)",
                "Lead 5 (charang)",
                "Lead 6 (voice)",
                "Lead 7 (fifths)",
                "Lead 8 (bass + lead)",
                "Pad 1 (Fantasia)",
                "Pad 2 (warm)",
                "Pad 3 (polysynth)",
                "Pad 4 (choir)",
                "Pad 5 (bowed)",
                "Pad 6 (metallic)",
                "Pad 7 (halo)",
                "Pad 8 (sweep)",
                "FX 1 (rain)",
                "FX 2 (soundtrack)",
                "FX 3 (crystal)",
                "FX 4 (atmosphere)",
                "FX 5 (brightness)",
                "FX 6 (goblins)",
                "FX 7 (echoes)",
                "FX 8 (sci-fi)",
                "Sitar",
                "Banjo",
                "Shamisen",
                "Koto",
                "Kalimba",
                "Bagpipe",
                "Fiddle",
                "Shanai",
                "Tinkle Bell",
                "Agogo",
                "Steel Drums",
                "Woodblock",
                "Taiko Drum",
                "Melodic Tom",
                "Synth Drum",
                "Reverse Cymbal",
                "Guitar Fret Noise",
                "Breath Noise",
                "Seashore",
                "Bird Tweet",
                "Telephone Ring",
                "Helicopter",
                "Applause",
                "Gunshot",
            };


        public static List<ComboItem<byte[]>> Reverbs = new List<ComboItem<byte[]>>()
            {
                new ComboItem<byte[]>() { Key = "off", Data = new byte[] { 0x00, 0x00 }},
                new ComboItem<byte[]>() { Key = "hall1", Data = new byte[] { 0x01, 0x00 }},
                new ComboItem<byte[]>() { Key = "hall2", Data = new byte[] { 0x01, 0x10 }},
                new ComboItem<byte[]>() { Key = "hall3", Data = new byte[] { 0x01, 0x11 }},
                new ComboItem<byte[]>() { Key = "hall4", Data = new byte[] { 0x01, 0x12 }},
                new ComboItem<byte[]>() { Key = "hall5", Data = new byte[] { 0x01, 0x01 }},
                new ComboItem<byte[]>() { Key = "hall_m", Data = new byte[] { 0x01, 0x06 }},
                new ComboItem<byte[]>() { Key = "hall_l", Data = new byte[] { 0x01, 0x07 }},

                new ComboItem<byte[]>() { Key = "room1", Data = new byte[] { 0x02, 0x10 }},
                new ComboItem<byte[]>() { Key = "room2", Data = new byte[] { 0x02, 0x11 }},
                new ComboItem<byte[]>() { Key = "room3", Data = new byte[] { 0x02, 0x12 }},
                new ComboItem<byte[]>() { Key = "room4", Data = new byte[] { 0x02, 0x13 }},
                new ComboItem<byte[]>() { Key = "room5", Data = new byte[] { 0x02, 0x00 }},
                new ComboItem<byte[]>() { Key = "room6", Data = new byte[] { 0x02, 0x01 }},
                new ComboItem<byte[]>() { Key = "room7", Data = new byte[] { 0x02, 0x02 }},
                new ComboItem<byte[]>() { Key = "room_s", Data = new byte[] { 0x02, 0x05 }},
                new ComboItem<byte[]>() { Key = "room_m", Data = new byte[] { 0x02, 0x06 }},
                new ComboItem<byte[]>() { Key = "room_l", Data = new byte[] { 0x02, 0x07 }},

                new ComboItem<byte[]>() { Key = "stage1", Data = new byte[] { 0x03, 0x10 }},
                new ComboItem<byte[]>() { Key = "stage2", Data = new byte[] { 0x03, 0x11 }},
                new ComboItem<byte[]>() { Key = "stage3", Data = new byte[] { 0x03, 0x00 }},
                new ComboItem<byte[]>() { Key = "stage4", Data = new byte[] { 0x03, 0x01 }},

                new ComboItem<byte[]>() { Key = "plate1", Data = new byte[] { 0x04, 0x10 }},
                new ComboItem<byte[]>() { Key = "plate2", Data = new byte[] { 0x04, 0x11 }},
                new ComboItem<byte[]>() { Key = "plate3", Data = new byte[] { 0x04, 0x00 }},
                new ComboItem<byte[]>() { Key = "gm_plate", Data = new byte[] { 0x04, 0x07 }},

                new ComboItem<byte[]>() { Key = "white_room", Data = new byte[] { 0x10, 0x00 }},
                new ComboItem<byte[]>() { Key = "tunnel", Data = new byte[] { 0x11, 0x00 }},
                new ComboItem<byte[]>() { Key = "canyon", Data = new byte[] { 0x12, 0x00 }},
                new ComboItem<byte[]>() { Key = "basement", Data = new byte[] { 0x13, 0x00 }},
            };


        public static List<ComboItem<byte[]>> Choruses = new List<ComboItem<byte[]>>
            {
                new ComboItem<byte[]>() { Key = "off", Data = new byte[] { 0x00, 0x00 }},

                new ComboItem<byte[]>() { Key = "chorus1", Data = new byte[] { 0x42, 0x11 }},
                new ComboItem<byte[]>() { Key = "chorus2", Data = new byte[] { 0x42, 0x08 }},
                new ComboItem<byte[]>() { Key = "chorus3", Data = new byte[] { 0x42, 0x10 }},
                new ComboItem<byte[]>() { Key = "chorus4", Data = new byte[] { 0x42, 0x01 }},
                new ComboItem<byte[]>() { Key = "chorus5", Data = new byte[] { 0x41, 0x02 }},
                new ComboItem<byte[]>() { Key = "chorus6", Data = new byte[] { 0x41, 0x00 }},
                new ComboItem<byte[]>() { Key = "chorus7", Data = new byte[] { 0x41, 0x01 }},
                new ComboItem<byte[]>() { Key = "chorus8", Data = new byte[] { 0x41, 0x08 }},
                new ComboItem<byte[]>() { Key = "gm_chorus1", Data = new byte[] { 0x41, 0x03 }},
                new ComboItem<byte[]>() { Key = "gm_chorus2", Data = new byte[] { 0x41, 0x04 }},
                new ComboItem<byte[]>() { Key = "gm_chorus3", Data = new byte[] { 0x41, 0x05 }},
                new ComboItem<byte[]>() { Key = "gm_chorus4", Data = new byte[] { 0x41, 0x06 }},
                new ComboItem<byte[]>() { Key = "fb_chorus", Data = new byte[] { 0x41, 0x07 }},

                new ComboItem<byte[]>() { Key = "celeste1", Data = new byte[] { 0x42, 0x00 }},
                new ComboItem<byte[]>() { Key = "celeste2", Data = new byte[] { 0x42, 0x02 }},

                new ComboItem<byte[]>() { Key = "flanger1", Data = new byte[] { 0x43, 0x08 }},
                new ComboItem<byte[]>() { Key = "flanger2", Data = new byte[] { 0x43, 0x10 }},
                new ComboItem<byte[]>() { Key = "flanger3", Data = new byte[] { 0x43, 0x11 }},
                new ComboItem<byte[]>() { Key = "flanger4", Data = new byte[] { 0x43, 0x01 }},

                new ComboItem<byte[]>() { Key = "flanger5", Data = new byte[] { 0x43, 0x00 }},
                new ComboItem<byte[]>() { Key = "gm_flanger2", Data = new byte[] { 0x43, 0x07 }},

                new ComboItem<byte[]>() { Key = "symphonic1", Data = new byte[] { 0x44, 0x10 }},
                new ComboItem<byte[]>() { Key = "symphonic2", Data = new byte[] { 0x44, 0x00 }},
                new ComboItem<byte[]>() { Key = "symphonic3", Data = new byte[] { 0x44, 0x12 }},
            };


        public static List<ComboItem<byte[]>> VarEffects = new List<ComboItem<byte[]>>
            {
                new ComboItem<byte[]>() {Key = "off", Data = new byte[] {0, 0}},
                new ComboItem<byte[]>() {Key = "HALL1", Data = new byte[] {1, 0}},
                new ComboItem<byte[]>() {Key = "HALL2", Data = new byte[] {1, 16}},
                new ComboItem<byte[]>() {Key = "HALL3", Data = new byte[] {1, 17}},
                new ComboItem<byte[]>() {Key = "HALL4", Data = new byte[] {1, 18}},
                new ComboItem<byte[]>() {Key = "HALL5", Data = new byte[] {1, 1}},
                new ComboItem<byte[]>() {Key = "HALL_M", Data = new byte[] {1, 6}},
                new ComboItem<byte[]>() {Key = "HALL_L", Data = new byte[] {1, 7}},
                new ComboItem<byte[]>() {Key = "ROOM1", Data = new byte[] {2, 16}},
                new ComboItem<byte[]>() {Key = "ROOM2", Data = new byte[] {2, 17}},
                new ComboItem<byte[]>() {Key = "ROOM3", Data = new byte[] {2, 18}},
                new ComboItem<byte[]>() {Key = "ROOM4", Data = new byte[] {2, 19}},
                new ComboItem<byte[]>() {Key = "ROOM5", Data = new byte[] {2, 0}},
                new ComboItem<byte[]>() {Key = "ROOM6", Data = new byte[] {2, 1}},
                new ComboItem<byte[]>() {Key = "ROOM7", Data = new byte[] {2, 2}},
                new ComboItem<byte[]>() {Key = "ROOM_S", Data = new byte[] {2, 5}},
                new ComboItem<byte[]>() {Key = "ROOM_M", Data = new byte[] {2, 6}},
                new ComboItem<byte[]>() {Key = "ROOM_L", Data = new byte[] {2, 7}},
                new ComboItem<byte[]>() {Key = "STAGE1", Data = new byte[] {3, 16}},
                new ComboItem<byte[]>() {Key = "STAGE2", Data = new byte[] {3, 17}},
                new ComboItem<byte[]>() {Key = "STAGE3", Data = new byte[] {3, 0}},
                new ComboItem<byte[]>() {Key = "STAGE4", Data = new byte[] {3, 1}},
                new ComboItem<byte[]>() {Key = "PLATE1", Data = new byte[] {4, 16}},
                new ComboItem<byte[]>() {Key = "PLATE2", Data = new byte[] {4, 17}},
                new ComboItem<byte[]>() {Key = "PLATE3", Data = new byte[] {4, 0}},
                new ComboItem<byte[]>() {Key = "GM_PLATE", Data = new byte[] {4, 7}},
                new ComboItem<byte[]>() {Key = "WHITE_ROOM", Data = new byte[] {16, 0}},
                new ComboItem<byte[]>() {Key = "TUNNEL_Simulates", Data = new byte[] {17, 0}},
                new ComboItem<byte[]>() {Key = "CANYON_A", Data = new byte[] {18, 0}},
                new ComboItem<byte[]>() {Key = "BASEMENT_A", Data = new byte[] {19, 0}},
                new ComboItem<byte[]>() {Key = "DELAY_LCR1", Data = new byte[] {5, 16}},
                new ComboItem<byte[]>() {Key = "DELAY_LCR2", Data = new byte[] {5, 0}},
                new ComboItem<byte[]>() {Key = "DELAY_LR", Data = new byte[] {6, 0}},
                new ComboItem<byte[]>() {Key = "ECHO_Two", Data = new byte[] {7, 0}},
                new ComboItem<byte[]>() {Key = "CROSS_DELAY", Data = new byte[] {8, 0}},
                new ComboItem<byte[]>() {Key = "TEMPO_DELAY", Data = new byte[] {21, 0}},
                new ComboItem<byte[]>() {Key = "TEMPO_ECHO", Data = new byte[] {21, 8}},
                new ComboItem<byte[]>() {Key = "TEMPO_CROSS", Data = new byte[] {22, 0}},
                new ComboItem<byte[]>() {Key = "KARAOKE1_20", Data = new byte[] {20, 0}},
                new ComboItem<byte[]>() {Key = "KARAOKE2_Echo", Data = new byte[] {20, 1}},
                new ComboItem<byte[]>() {Key = "KARAOKE3_20", Data = new byte[] {20, 2}},
                new ComboItem<byte[]>() {Key = "ER1_9", Data = new byte[] {9, 0}},
                new ComboItem<byte[]>() {Key = "ER2_9", Data = new byte[] {9, 1}},
                new ComboItem<byte[]>() {Key = "GATE_REVERB", Data = new byte[] {10, 0}},
                new ComboItem<byte[]>() {Key = "REVERS_GATE", Data = new byte[] {11, 0}},
                new ComboItem<byte[]>() {Key = "CHORUS1", Data = new byte[] {66, 17}},
                new ComboItem<byte[]>() {Key = "CHORUS2", Data = new byte[] {66, 8}},
                new ComboItem<byte[]>() {Key = "CHORUS3", Data = new byte[] {66, 16}},
                new ComboItem<byte[]>() {Key = "CHORUS4", Data = new byte[] {66, 1}},
                new ComboItem<byte[]>() {Key = "CHORUS5", Data = new byte[] {65, 2}},
                new ComboItem<byte[]>() {Key = "CHORUS6", Data = new byte[] {65, 0}},
                new ComboItem<byte[]>() {Key = "CHORUS7", Data = new byte[] {65, 1}},
                new ComboItem<byte[]>() {Key = "CHORUS8", Data = new byte[] {65, 8}},
                new ComboItem<byte[]>() {Key = "GM_CHORUS1", Data = new byte[] {65, 3}},
                new ComboItem<byte[]>() {Key = "GM_CHORUS2", Data = new byte[] {65, 4}},
                new ComboItem<byte[]>() {Key = "GM_CHORUS3", Data = new byte[] {65, 5}},
                new ComboItem<byte[]>() {Key = "GM_CHORUS4", Data = new byte[] {65, 6}},
                new ComboItem<byte[]>() {Key = "FB_CHORUS", Data = new byte[] {0, 0}},
                new ComboItem<byte[]>() {Key = "CELESTE1", Data = new byte[] {66, 0}},
                new ComboItem<byte[]>() {Key = "CELESTE2", Data = new byte[] {66, 2}},
                new ComboItem<byte[]>() {Key = "SYMPHONIC1", Data = new byte[] {68, 16}},
                new ComboItem<byte[]>() {Key = "SYMPHONIC2", Data = new byte[] {68, 0}},
                new ComboItem<byte[]>() {Key = "ENS", Data = new byte[] {87, 0}},
                new ComboItem<byte[]>() {Key = "FLANGER1", Data = new byte[] {67, 8}},
                new ComboItem<byte[]>() {Key = "FLANGER2", Data = new byte[] {67, 16}},
                new ComboItem<byte[]>() {Key = "FLANGER3", Data = new byte[] {67, 17}},
                new ComboItem<byte[]>() {Key = "FLANGER4", Data = new byte[] {67, 1}},
                new ComboItem<byte[]>() {Key = "FLANGER5", Data = new byte[] {67, 0}},
                new ComboItem<byte[]>() {Key = "GM_FLANGER", Data = new byte[] {67, 7}},
                new ComboItem<byte[]>() {Key = "T_FLANGER", Data = new byte[] {107, 0}},
                new ComboItem<byte[]>() {Key = "PHASER1", Data = new byte[] {72, 0}},
                new ComboItem<byte[]>() {Key = "PHASER2", Data = new byte[] {72, 8}},
                new ComboItem<byte[]>() {Key = "EP_PHASER2", Data = new byte[] {72, 18}},
                new ComboItem<byte[]>() {Key = "EP_PHASER3", Data = new byte[] {72, 16}},
                new ComboItem<byte[]>() {Key = "T_PHASER", Data = new byte[] {108, 0}},
                new ComboItem<byte[]>() {Key = "DIST_HEAVY", Data = new byte[] {73, 0}},
                new ComboItem<byte[]>() {Key = "ST_DIST", Data = new byte[] {73, 8}},
                new ComboItem<byte[]>() {Key = "COMP+DIST1", Data = new byte[] {73, 16}},
                new ComboItem<byte[]>() {Key = "COMP+DIST2", Data = new byte[] {73, 1}},
                new ComboItem<byte[]>() {Key = "OVERDRIVE", Data = new byte[] {74, 0}},
                new ComboItem<byte[]>() {Key = "ST_OD", Data = new byte[] {74, 8}},
                new ComboItem<byte[]>() {Key = "DIST_HARD1", Data = new byte[] {75, 16}},
                new ComboItem<byte[]>() {Key = "DIST_HARD2", Data = new byte[] {75, 22}},
                new ComboItem<byte[]>() {Key = "DIST_SOFT1", Data = new byte[] {75, 17}},
                new ComboItem<byte[]>() {Key = "DIST_SOFT2", Data = new byte[] {75, 23}},
                new ComboItem<byte[]>() {Key = "ST_DIST", Data = new byte[] {75, 18}},
                new ComboItem<byte[]>() {Key = "ST_DIST", Data = new byte[] {75, 19}},
                new ComboItem<byte[]>() {Key = "V_DIST_HARD", Data = new byte[] {98, 0}},
                new ComboItem<byte[]>() {Key = "V_DIST_SOFT", Data = new byte[] {98, 2}},
                new ComboItem<byte[]>() {Key = "AMP_SIM1", Data = new byte[] {75, 0}},
                new ComboItem<byte[]>() {Key = "AMP_SIM2", Data = new byte[] {75, 1}},
                new ComboItem<byte[]>() {Key = "ST_AMP1", Data = new byte[] {75, 20}},
                new ComboItem<byte[]>() {Key = "ST_AMP2", Data = new byte[] {75, 21}},
                new ComboItem<byte[]>() {Key = "ST_AMP3", Data = new byte[] {75, 8}},
                new ComboItem<byte[]>() {Key = "ST_AMP4", Data = new byte[] {75, 24}},
                new ComboItem<byte[]>() {Key = "ST_AMP5", Data = new byte[] {75, 25}},
                new ComboItem<byte[]>() {Key = "ST_AMP6", Data = new byte[] {75, 26}},
                new ComboItem<byte[]>() {Key = "DST+DELAY1", Data = new byte[] {95, 16}},
                new ComboItem<byte[]>() {Key = "DST+DELAY2", Data = new byte[] {95, 0}},
                new ComboItem<byte[]>() {Key = "OD+DELAY1", Data = new byte[] {95, 17}},
                new ComboItem<byte[]>() {Key = "OD+DELAY2", Data = new byte[] {95, 1}},
                new ComboItem<byte[]>() {Key = "CMP+DST+DLY1", Data = new byte[] {96, 16}},
                new ComboItem<byte[]>() {Key = "CMP+DST+DLY2", Data = new byte[] {96, 0}},
                new ComboItem<byte[]>() {Key = "CMP+OD+DLY1", Data = new byte[] {96, 17}},
                new ComboItem<byte[]>() {Key = "CMP+OD+DLY2", Data = new byte[] {96, 1}},
                new ComboItem<byte[]>() {Key = "V_DST", Data = new byte[] {98, 1}},
                new ComboItem<byte[]>() {Key = "V_DST", Data = new byte[] {98, 3}},
                new ComboItem<byte[]>() {Key = "DST+TDLY", Data = new byte[] {100, 0}},
                new ComboItem<byte[]>() {Key = "OD+TDLY", Data = new byte[] {100, 1}},
                new ComboItem<byte[]>() {Key = "CMP+DST+TDL", Data = new byte[] {101, 0}},
                new ComboItem<byte[]>() {Key = "CMP+OD+TDLY1", Data = new byte[] {101, 1}},
                new ComboItem<byte[]>() {Key = "CMP+OD+TDLY2", Data = new byte[] {101, 16}},
                new ComboItem<byte[]>() {Key = "CMP+OD+TDLY3", Data = new byte[] {101, 17}},
                new ComboItem<byte[]>() {Key = "CMP+OD+TDLY4", Data = new byte[] {101, 18}},
                new ComboItem<byte[]>() {Key = "CMP+OD+TDLY5", Data = new byte[] {101, 19}},
                new ComboItem<byte[]>() {Key = "CMP+OD+TDLY6", Data = new byte[] {101, 20}},
                new ComboItem<byte[]>() {Key = "V_DST_H+TDLY1", Data = new byte[] {103, 0}},
                new ComboItem<byte[]>() {Key = "V_DST_S+TDL1", Data = new byte[] {103, 1}},
                new ComboItem<byte[]>() {Key = "PITCH_CHG1", Data = new byte[] {80, 16}},
                new ComboItem<byte[]>() {Key = "PITCH_CHG2", Data = new byte[] {80, 0}},
                new ComboItem<byte[]>() {Key = "PITCH_CHG3", Data = new byte[] {80, 1}},
                new ComboItem<byte[]>() {Key = "AUTO_WAH1", Data = new byte[] {78, 16}},
                new ComboItem<byte[]>() {Key = "AUTO_WAH2", Data = new byte[] {78, 0}},
                new ComboItem<byte[]>() {Key = "AT_WAH+DST1", Data = new byte[] {78, 17}},
                new ComboItem<byte[]>() {Key = "AT_WAH+DST2", Data = new byte[] {78, 1}},
                new ComboItem<byte[]>() {Key = "AT_WAH+OD1", Data = new byte[] {78, 18}},
                new ComboItem<byte[]>() {Key = "AT_WAH+OD2", Data = new byte[] {78, 2}},
                new ComboItem<byte[]>() {Key = "TOUCH_WAH1", Data = new byte[] {82, 0}},
                new ComboItem<byte[]>() {Key = "TOUCH_WAH2", Data = new byte[] {82, 8}},
                new ComboItem<byte[]>() {Key = "TC_WAH+DST1", Data = new byte[] {82, 16}},
                new ComboItem<byte[]>() {Key = "TC_WAH+DST2", Data = new byte[] {82, 1}},
                new ComboItem<byte[]>() {Key = "TC_WAH+OD1", Data = new byte[] {82, 17}},
                new ComboItem<byte[]>() {Key = "TC_WAH+OD2", Data = new byte[] {82, 2}},
                new ComboItem<byte[]>() {Key = "CLAVI_TC", Data = new byte[] {82, 18}},
                new ComboItem<byte[]>() {Key = "EP_TC", Data = new byte[] {82, 19}},
                new ComboItem<byte[]>() {Key = "WH+DST+DLY1", Data = new byte[] {97, 16}},
                new ComboItem<byte[]>() {Key = "WH+DST+DLY2", Data = new byte[] {97, 0}},
                new ComboItem<byte[]>() {Key = "WH+DST+TDLY", Data = new byte[] {102, 0}},
                new ComboItem<byte[]>() {Key = "WH+OD+DLY1", Data = new byte[] {97, 17}},
                new ComboItem<byte[]>() {Key = "WH+OD+DLY2", Data = new byte[] {97, 1}},
                new ComboItem<byte[]>() {Key = "WH+OD+TDLY1", Data = new byte[] {102, 1}},
                new ComboItem<byte[]>() {Key = "WH+OD+TDLY2", Data = new byte[] {102, 16}},
                new ComboItem<byte[]>() {Key = "MBAND_COMP", Data = new byte[] {105, 0}},
                new ComboItem<byte[]>() {Key = "COMPRESSOR", Data = new byte[] {84, 0}},
                new ComboItem<byte[]>() {Key = "NOISE", Data = new byte[] {83, 0}},
                new ComboItem<byte[]>() {Key = "ROTARY_SP1", Data = new byte[] {69, 16}},
                new ComboItem<byte[]>() {Key = "ROTARY_SP2", Data = new byte[] {71, 17}},
                new ComboItem<byte[]>() {Key = "ROTARY_SP3", Data = new byte[] {71, 18}},
                new ComboItem<byte[]>() {Key = "ROTARY_SP4", Data = new byte[] {70, 17}},
                new ComboItem<byte[]>() {Key = "ROTARY_SP5", Data = new byte[] {66, 18}},
                new ComboItem<byte[]>() {Key = "ROTARY_SP6", Data = new byte[] {69, 0}},
                new ComboItem<byte[]>() {Key = "ROTARY_SP7", Data = new byte[] {71, 22}},
                new ComboItem<byte[]>() {Key = "2WAY_ROT", Data = new byte[] {86, 0}},
                new ComboItem<byte[]>() {Key = "DST+ROT_SP", Data = new byte[] {69, 1}},
                new ComboItem<byte[]>() {Key = "DST+2ROT_SP", Data = new byte[] {86, 1}},
                new ComboItem<byte[]>() {Key = "OD+ROT_SP", Data = new byte[] {69, 2}},
                new ComboItem<byte[]>() {Key = "OD+2ROT_SP", Data = new byte[] {86, 2}},
                new ComboItem<byte[]>() {Key = "AMP+ROT_SP", Data = new byte[] {69, 3}},
                new ComboItem<byte[]>() {Key = "AMP+2ROT_SP", Data = new byte[] {86, 3}},
                new ComboItem<byte[]>() {Key = "DUAL_ROT", Data = new byte[] {99, 0}},
                new ComboItem<byte[]>() {Key = "DUAL_ROT", Data = new byte[] {99, 1}},
                new ComboItem<byte[]>() {Key = "TREMOLO1_70", Data = new byte[] {70, 16}},
                new ComboItem<byte[]>() {Key = "TREMOLO2_71", Data = new byte[] {71, 19}},
                new ComboItem<byte[]>() {Key = "TREMOLO3_Rich", Data = new byte[] {70, 0}},
                new ComboItem<byte[]>() {Key = "EP_TREMOLO", Data = new byte[] {70, 18}},
                new ComboItem<byte[]>() {Key = "GT_TREMOLO1", Data = new byte[] {71, 20}},
                new ComboItem<byte[]>() {Key = "GT_TREMOLO2", Data = new byte[] {70, 19}},
                new ComboItem<byte[]>() {Key = "AUTO_PAN1", Data = new byte[] {71, 16}},
                new ComboItem<byte[]>() {Key = "AUTO_PAN2", Data = new byte[] {71, 0}},
                new ComboItem<byte[]>() {Key = "EP_AUTOPAN", Data = new byte[] {71, 21}},
                new ComboItem<byte[]>() {Key = "AUTO_PAN3", Data = new byte[] {71, 1}},
                new ComboItem<byte[]>() {Key = "EQ_DISCO", Data = new byte[] {76, 16}},
                new ComboItem<byte[]>() {Key = "EQ_TEL", Data = new byte[] {76, 17}},
                new ComboItem<byte[]>() {Key = "2BAND_EQ", Data = new byte[] {77, 0}},
                new ComboItem<byte[]>() {Key = "3BAND_EQ", Data = new byte[] {76, 0}},
                new ComboItem<byte[]>() {Key = "HM_ENHANCE1", Data = new byte[] {81, 16}},
                new ComboItem<byte[]>() {Key = "HM_ENHANCE2", Data = new byte[] {81, 0}},
                new ComboItem<byte[]>() {Key = "ST_3BAND", Data = new byte[] {76, 18}},
                new ComboItem<byte[]>() {Key = "VCE_CANCEL", Data = new byte[] {85, 0}},
                new ComboItem<byte[]>() {Key = "AMBIENCE_Blurs", Data = new byte[] {88, 0}},
                new ComboItem<byte[]>() {Key = "TALKING_MOD", Data = new byte[] {93, 0}},
                new ComboItem<byte[]>() {Key = "ISOLATOR_Controls", Data = new byte[] {115, 0}},
                new ComboItem<byte[]>() {Key = "NO_EFFECT", Data = new byte[] {0, 0}},
                new ComboItem<byte[]>() {Key = "THRU_Bypass", Data = new byte[] {64, 0}},
            };
    }
}
