using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPBits_float_FPBits_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6FPBitsIfEC2IjEET_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::FPBits<float>::FPBits<unsigned int>(unsigned int)")]
	public unsafe static void Invoke(fputil_FPBits_5nkvcs* @this, [NativeType("unsigned int")] int x)
	{
		unchecked
		{
			FPRepImpl_fputil_FPType_1_fputil_FPBits_float_Constructor.Invoke((fputil_internal_FPRepImpl_vhj4tm*)@this);
			((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0 = x;
		}
	}
}
