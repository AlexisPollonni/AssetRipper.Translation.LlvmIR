using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIPNS_4FileEiEC2ES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::expected<__llvm_libc_20_1_2_::File*, int>::expected(__llvm_libc_20_1_2_::File*)")]
internal static partial class cpp_expected_File_int_expected_File
{
	public unsafe static void Invoke(void* @this, File_sjnxn4* exp)
	{
		unchecked
		{
			*(File_sjnxn4**)(&((cpp_optional_char_OptionalStorage*)@this)->field) = exp;
			((cpp_optional_char_OptionalStorage*)@this)->in_use = 1;
		}
	}
}
