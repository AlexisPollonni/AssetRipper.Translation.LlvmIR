using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StrictIntegralType_unsigned_int_zero
{
	[MangledName("_ZN19__llvm_libc_20_1_2_18StrictIntegralTypeIjE4zeroEv")]
	[DemangledName("__llvm_libc_20_1_2_::StrictIntegralType<unsigned int>::zero()")]
	public unsafe static int Invoke()
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		StrictIntegralType_unsigned_int_StrictIntegralType_unsigned_int_false.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2, 0);
		return fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0;
	}
}
