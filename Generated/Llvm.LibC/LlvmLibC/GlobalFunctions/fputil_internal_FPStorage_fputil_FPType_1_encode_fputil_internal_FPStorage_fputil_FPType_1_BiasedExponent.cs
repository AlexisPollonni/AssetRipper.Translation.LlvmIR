using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE1EE6encodeENS4_14BiasedExponentE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::encode(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::BiasedExponent)")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_1_encode_fputil_internal_FPStorage_fputil_FPType_1_BiasedExponent
{
	public unsafe static int Invoke([MangledName("exp.coerce")] int exp)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = new fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent
		{
			field_0 = 
			{
				field_0 = exp
			}
		};
		return (fputil_internal_FPStorage_fputil_FPType_1_TypedInt_unsigned_int_to_storage_type_const.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2) << 23) & 0x7F800000;
	}
}
