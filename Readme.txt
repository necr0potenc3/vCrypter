====================================

 vCrypt is a tool by Valios to calculate Ultima Online login keys based on the client's version.

 Leaked source code obtained by the decompilation of the executable.

 Valios' code is pretty much a copy of OpenUO and if I remember correctly OpenUO's login keys code is inspired by POL's:

OpenUO Version:

namespace OpenUO.Ultima
{
    public static class ClientUtility
    {
        public static void CalculateLoginKeys(uint major, uint minor, uint revision, uint build, out uint key1, out uint key2)
        {
            key1 = (major << 23) | (minor << 14) | (revision << 4);
            key1 ^= (revision * revision) << 9;
            key1 ^= (minor * minor);
            key1 ^= (minor * 11) << 24;
            key1 ^= (revision * 7) << 19;
            key1 ^= 0x2C13A5FD;

            key2 = (major << 22) | (revision << 13) | (minor << 3);
            key2 ^= (revision * revision * 3) << 10;
            key2 ^= (minor * minor);
            key2 ^= (minor * 13) << 23;
            key2 ^= (revision * 7) << 18;
            key2 ^= 0xA31D527F;
        }
    }
}

POL's Version:

void CalculateCryptKeys( const std::string& name, TCryptInfo& infoCrypt )
00031     {
00032       size_t len = name.length();
00033       if ( ( strnicmp( "none", name.c_str(), len ) == 0 )
00034            || ( strnicmp( "ignition", name.c_str(), len ) == 0 )
00035            || ( strnicmp( "uorice", name.c_str(), len ) == 0 ) )
00036       {
00037         infoCrypt.eType = CRYPT_NOCRYPT;
00038         infoCrypt.uiKey1 = 0;
00039         infoCrypt.uiKey2 = 0;
00040       }
00041       else if ( strnicmp( "2.0.0x", name.c_str(), 6 ) == 0 )
00042       {
00043         infoCrypt.eType = CRYPT_BLOWFISH_TWOFISH;
00044         infoCrypt.uiKey1 = 0x2D13A5FD;
00045         infoCrypt.uiKey2 = 0xA39D527F;
00046       }
00047       else
00048       {
00049         try
00050         {
00051           size_t dot1 = name.find_first_of( '.', 0 );
00052           size_t dot2 = name.find_first_of( '.', dot1 + 1 );
00053 
00054           int major = atoi( name.substr( 0, dot1 ).c_str() );
00055           int minor = atoi( name.substr( dot1 + 1, dot2 - dot1 - 1 ).c_str() );
00056           int build = atoi( name.substr( dot2 + 1, len - dot2 - 1 ).c_str() );
00057 
00058           int temp = ( ( major << 9 | minor ) << 10 | build ) ^ ( ( build*build ) << 5 );
00059           infoCrypt.uiKey1 = ( temp << 4 ) ^ ( minor*minor ) ^ ( minor * 0x0B000000 ) ^ ( build * 0x380000 ) ^ 0x2C13A5FD;
00060           temp = ( ( ( major << 9 | build ) << 10 | minor ) * 8 ) ^ ( build*build * 0x0c00 );
00061           infoCrypt.uiKey2 = temp ^ ( minor*minor ) ^ ( minor * 0x6800000 ) ^ ( build * 0x1c0000 ) ^ 0x0A31D527F;
00062 
00063           if ( compareVersion( 1, 25, 35, major, minor, build ) )
00064             infoCrypt.eType = CRYPT_OLD_BLOWFISH;
00065           else if ( ( major == 1 ) && ( minor == 25 ) && ( build == 36 ) )
00066             infoCrypt.eType = CRYPT_1_25_36;
00067           else if ( compareVersion( 2, 0, 0, major, minor, build ) )
00068             infoCrypt.eType = CRYPT_BLOWFISH;
00069           else if ( compareVersion( 2, 0, 3, major, minor, build ) )
00070             infoCrypt.eType = CRYPT_BLOWFISH_TWOFISH;
00071           else
00072             infoCrypt.eType = CRYPT_TWOFISH;
00073         }
00074         catch ( ... )
00075         {
00076           infoCrypt.eType = CRYPT_NOCRYPT;
00077           infoCrypt.uiKey1 = 0;
00078           infoCrypt.uiKey2 = 0;
00079           POLLOG_ERROR << "Malformed encryption version string: " << name << "using Ignition encryption engine\n";
00080         }
00081       }
00082     }
00083 
00084     bool compareVersion( int ver1major, int ver1minor, int ver1build, int ver2major, int ver2minor, int ver2build )
00085     {
00086       if ( ver1major > ver2major )
00087         return true;
00088       else if ( ver1major < ver2major )
00089         return false;
00090       else if ( ver1minor > ver2minor )
00091         return true;
00092       else if ( ver1minor < ver2minor )
00093         return false;
00094       else if ( ver1build > ver2build )
00095         return true;
00096       else if ( ver1build < ver2build )
00097         return false;
00098       else
00099         return true;
00100     }

 - necr0potenc3
====================================