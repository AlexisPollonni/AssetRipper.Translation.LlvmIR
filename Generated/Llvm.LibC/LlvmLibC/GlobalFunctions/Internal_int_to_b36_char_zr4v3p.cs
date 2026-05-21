using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_int_to_b36_char_zr4v3p
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internalL15int_to_b36_charEi")]
	[DemangledName("__llvm_libc_20_1_2_::internal::int_to_b36_char(int)")]
	[CleanName("Internal_int_to_b36_char")]
	public static int Invoke([MangledName("num")][NativeType("int")] int Num)
	{
		return Num switch
		{
			0 => 48, 
			1 => 49, 
			2 => 50, 
			3 => 51, 
			4 => 52, 
			5 => 53, 
			6 => 54, 
			7 => 55, 
			8 => 56, 
			9 => 57, 
			10 => 97, 
			11 => 98, 
			12 => 99, 
			13 => 100, 
			14 => 101, 
			15 => 102, 
			16 => 103, 
			17 => 104, 
			18 => 105, 
			19 => 106, 
			20 => 107, 
			21 => 108, 
			22 => 109, 
			23 => 110, 
			24 => 111, 
			25 => 112, 
			26 => 113, 
			27 => 114, 
			28 => 115, 
			29 => 116, 
			30 => 117, 
			31 => 118, 
			32 => 119, 
			33 => 120, 
			34 => 121, 
			35 => 122, 
			_ => 33, 
		};
	}
}
