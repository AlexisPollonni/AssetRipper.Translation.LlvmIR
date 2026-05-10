using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE6encodeENS4_14BiasedExponentE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::encode(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::BiasedExponent)")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_0_encode_fputil_internal_FPStorage_fputil_FPType_0_BiasedExponent
{
	public unsafe static short Invoke([MangledName("exp.coerce")] int exp)
	{
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2 = new fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent
		{
			field_0 = 
			{
				field_0 = exp
			}
		};
		return unchecked((short)(((ushort)fputil_internal_FPStorage_fputil_FPType_0_TypedInt_unsigned_int_to_storage_type_const.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_BiasedExponent2) << 10) & 0x7C00));
	}
}
