using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE6encodeENS4_11SignificandE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::encode(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand)")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_0_encode_fputil_internal_FPStorage_fputil_FPType_0_Significand
{
	public unsafe static short Invoke([MangledName("value.coerce")] short value)
	{
		fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h2 = new fputil_internal_FPRepSem_i7nz4h
		{
			FPStorage = 
			{
				field_0 = value
			}
		};
		return unchecked((short)((ushort)fputil_internal_FPStorage_fputil_FPType_0_TypedInt_unsigned_short_to_storage_type_const.Invoke(&fputil_internal_FPRepSem_i7nz4h2) & 0x3FF));
	}
}
