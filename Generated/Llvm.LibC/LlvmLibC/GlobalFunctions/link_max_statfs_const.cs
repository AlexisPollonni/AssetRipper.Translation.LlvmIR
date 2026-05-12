using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8link_maxERK6statfs")]
[DemangledName("__llvm_libc_20_1_2_::link_max(statfs const&)")]
internal static partial class link_max_statfs_const
{
	public unsafe static long Invoke(statfs* s)
	{
		return s->f_type switch
		{
			61267L => 32000L, 
			4991L => 250L, 
			9320L => 65530L, 
			1382369651L => 64535L, 
			72020L => 32000L, 
			_ => 127L, 
		};
	}
}
