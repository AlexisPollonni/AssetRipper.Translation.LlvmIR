using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_link_max
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8link_maxERK6statfs")]
	[DemangledName("__llvm_libc_20_1_2_::link_max(statfs const&)")]
	public unsafe static long Invoke([MangledName("s")][NativeType("statfs const&")] Statfs* S)
	{
		return S->F_type switch
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
