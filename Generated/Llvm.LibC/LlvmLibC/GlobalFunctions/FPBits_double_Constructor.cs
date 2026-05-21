using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPBits_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIdEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<double>::FPBits()")]
	public unsafe static void Invoke(void* @this)
	{
		FPRepImpl_fputil_FPType_2_fputil_FPBits_double_Constructor.Invoke(unchecked((fputil_internal_FPRepImpl_ucubaq*)@this));
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIdEC2IdEET_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<double>::FPBits<double>(double)")]
	public unsafe static void Invoke(void* @this, [NativeType("double")] double x)
	{
		double num = x;
		unchecked
		{
			FPRepImpl_fputil_FPType_2_fputil_FPBits_double_Constructor.Invoke((fputil_internal_FPRepImpl_ucubaq*)@this);
			((fputil_internal_FPStorage_v3nexn*)@this)->val = cpp_bit_cast_unsigned_long_double.Invoke(&num);
		}
	}
}
