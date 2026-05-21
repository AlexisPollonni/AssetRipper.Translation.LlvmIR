using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPBits_double_FPBits_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIdEC2ImEET_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<double>::FPBits<unsigned long>(unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("x")][NativeType("unsigned long")] long X)
	{
		unchecked
		{
			FPRepImpl_fputil_FPType_2_fputil_FPBits_double_Constructor.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)This);
			((Llvm_libc_20_1_2_fputil_internal_FPStorage_v3nexn*)This)->Val = X;
		}
	}
}
