using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE6encodeENS4_11SignificandE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::encode(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::Significand)")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_2_encode_fputil_internal_FPStorage_fputil_FPType_2_Significand
{
	public unsafe static long Invoke([MangledName("value.coerce")] long value)
	{
		fputil_internal_FPRepSem_fq8nhg fputil_internal_FPRepSem_fq8nhg2 = new fputil_internal_FPRepSem_fq8nhg
		{
			FPStorage = 
			{
				val = value
			}
		};
		return fputil_internal_FPStorage_fputil_FPType_2_TypedInt_unsigned_long_to_storage_type_const.Invoke(&fputil_internal_FPRepSem_fq8nhg2) & 0xFFFFFFFFFFFFFL;
	}
}
