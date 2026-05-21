using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPBits_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIdEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<double>::FPBits()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		FPRepImpl_fputil_FPType_2_fputil_FPBits_double_Constructor.Invoke(unchecked((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)This));
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIdEC2IdEET_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<double>::FPBits<double>(double)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("x")][NativeType("double")] double X)
	{
		double num = X;
		unchecked
		{
			FPRepImpl_fputil_FPType_2_fputil_FPBits_double_Constructor.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)This);
			((Llvm_libc_20_1_2_fputil_internal_FPStorage_v3nexn*)This)->Val = Cpp_bit_cast_unsigned_long_double.Invoke(&num);
		}
	}
}
