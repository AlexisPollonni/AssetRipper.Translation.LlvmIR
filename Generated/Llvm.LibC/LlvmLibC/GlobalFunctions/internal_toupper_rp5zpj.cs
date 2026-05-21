using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_toupper_rp5zpj
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internalL7toupperEi")]
	[DemangledName("__llvm_libc_20_1_2_::internal::toupper(int)")]
	[CleanName("internal_toupper")]
	public static int Invoke([NativeType("int")] int ch)
	{
		return ch switch
		{
			97 => 65, 
			98 => 66, 
			99 => 67, 
			100 => 68, 
			101 => 69, 
			102 => 70, 
			103 => 71, 
			104 => 72, 
			105 => 73, 
			106 => 74, 
			107 => 75, 
			108 => 76, 
			109 => 77, 
			110 => 78, 
			111 => 79, 
			112 => 80, 
			113 => 81, 
			114 => 82, 
			115 => 83, 
			116 => 84, 
			117 => 85, 
			118 => 86, 
			119 => 87, 
			120 => 88, 
			121 => 89, 
			122 => 90, 
			_ => ch, 
		};
	}
}
