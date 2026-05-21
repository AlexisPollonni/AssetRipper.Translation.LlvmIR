using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_tolower_ec4z38
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internalL7tolowerEi.119")]
	[DemangledName("__llvm_libc_20_1_2_::internal::tolower(int) (.119)")]
	[CleanName("Internal_tolower")]
	public static int Invoke([MangledName("ch")][NativeType("int")] int Ch)
	{
		return Ch switch
		{
			65 => 97, 
			66 => 98, 
			67 => 99, 
			68 => 100, 
			69 => 101, 
			70 => 102, 
			71 => 103, 
			72 => 104, 
			73 => 105, 
			74 => 106, 
			75 => 107, 
			76 => 108, 
			77 => 109, 
			78 => 110, 
			79 => 111, 
			80 => 112, 
			81 => 113, 
			82 => 114, 
			83 => 115, 
			84 => 116, 
			85 => 117, 
			86 => 118, 
			87 => 119, 
			88 => 120, 
			89 => 121, 
			90 => 122, 
			_ => Ch, 
		};
	}
}
