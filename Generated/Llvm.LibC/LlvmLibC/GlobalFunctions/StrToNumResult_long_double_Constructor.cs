using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrToNumResult_long_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14StrToNumResultIeEC2Eeli")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<long double>::StrToNumResult(long double, long, int)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("value")][NativeType("long double")] double Value, [MangledName("parsed_len")][NativeType("long")] long Parsed_len, [MangledName("error")][NativeType("int")] int Error)
	{
		unchecked
		{
			((StrToNumResult_uytq62*)This)->Value = Value;
			((StrToNumResult_uytq62*)This)->Error = Error;
			((StrToNumResult_uytq62*)This)->Parsed_len = Parsed_len;
		}
	}
}
