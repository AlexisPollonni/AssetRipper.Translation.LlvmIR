using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_int_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIiEC2Eili")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<int>::StrToNumResult(int, long, int)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("value")][NativeType("int")] int Value, [MangledName("parsed_len")][NativeType("long")] long Parsed_len, [MangledName("error")][NativeType("int")] int Error)
	{
		unchecked
		{
			((Llvm_libc_20_1_2_StrToNumResult_imtnam*)This)->Value = Value;
			((Llvm_libc_20_1_2_StrToNumResult_imtnam*)This)->Error = Error;
			((Llvm_libc_20_1_2_StrToNumResult_imtnam*)This)->Parsed_len = Parsed_len;
		}
	}
}
