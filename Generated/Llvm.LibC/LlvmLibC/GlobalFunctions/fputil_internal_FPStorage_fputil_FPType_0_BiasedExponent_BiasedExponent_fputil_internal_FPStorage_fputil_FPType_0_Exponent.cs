using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE14BiasedExponentC2ENS4_8ExponentE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::BiasedExponent::BiasedExponent(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Exponent)")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_0_BiasedExponent_BiasedExponent_fputil_internal_FPStorage_fputil_FPType_0_Exponent
{
	public unsafe static void Invoke(void* @this, [MangledName("exp.coerce")] int exp)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = new fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent
		{
			field_0 = 
			{
				field_0 = exp
			}
		};
		fputil_internal_FPStorage_fputil_FPType_0_TypedInt_unsigned_int_TypedInt_unsigned_int.Invoke(@this, fputil_internal_FPStorage_fputil_FPType_0_TypedInt_int_operator_int_const.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2) + 15);
	}
}
