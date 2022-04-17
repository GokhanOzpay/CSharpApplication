using System;
using System.Collections.Generic;
using System.Text;


    internal class DataTypes
    {

        char c = 'v'; // Hafıza boyutu  1 byte min:  -128 max: 127
        short s = 0; // Hafıza boyutu 2 byte  min: -32,768 max: 32,767
        ushort u = 0;// Hafıza boyutu 2 byte  min: 0 max: 65,535
        int i = 0;// Hafıza boyutu 4 byte min: -2,147,483,648 max: -2,147,483,647
        uint u2 = 0; // Hafıza boyutu 4 byte  min: 0 max: 4,294,967,295
        long l = 0; // Hafıza boyutu 8 byte  min: ?9,223,372,036,854,775,808 max: 9,223,372,036,854,775,807
        ulong ul=0; // Hafıza boyutu 8 byte  min: 0 - 18,446,744,073,709,551,615
        float f = 0; // Hafıza boyutu 4 byte  min: 1.5 * 10-45 - 3.4 * 1038, 7 basamaklı hassasiyetle
        double d = 0;// Hafıza boyutu 8 byte min: 5.0 * 10-324 - 1.7 * 10308, 15 basamaklı hassasiyetle
        decimal dec=0;//Hafıza boyutu  16 byte en az -7.9 * 10?28 - 7.9 * 1028, en az 28 basamaklı hassasiyetle
        string data = "Data";// iki Tırnak Arası Yazılır.
        object obj=null;
        dynamic dyn = 1;
        /*
         * şaretçiler ve sabit boyutlu arabellekler yalnızca güvenli olmayan bir bağlamda kullanılabilir
        char* cptr;
        int* iptr;
        */

    }

