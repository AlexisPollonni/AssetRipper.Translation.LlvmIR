using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE8TypedIntImE15to_storage_typeEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::TypedInt<unsigned long>::to_storage_type() const")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_2_TypedInt_unsigned_long_to_storage_type_const
{
	public unsafe static long Invoke(void* @this)
	{
		return unchecked((fputil_internal_FPStorage_v3nexn*)@this)->val;
	}
}
