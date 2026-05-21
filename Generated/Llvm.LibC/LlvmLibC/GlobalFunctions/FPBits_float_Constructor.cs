using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPBits_float_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIfEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<float>::FPBits()")]
	public unsafe static void Invoke(fputil_FPBits_5nkvcs* @this)
	{
		FPRepImpl_fputil_FPType_1_fputil_FPBits_float_Constructor.Invoke(unchecked((fputil_internal_FPRepImpl_vhj4tm*)@this));
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIfEC2IfEET_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<float>::FPBits<float>(float)")]
	public unsafe static void Invoke(fputil_FPBits_5nkvcs* @this, [NativeType("float")] float x)
	{
		float num = x;
		unchecked
		{
			FPRepImpl_fputil_FPType_1_fputil_FPBits_float_Constructor.Invoke((fputil_internal_FPRepImpl_vhj4tm*)@this);
			((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0 = cpp_bit_cast_unsigned_int_float.Invoke(&num);
		}
	}
}
