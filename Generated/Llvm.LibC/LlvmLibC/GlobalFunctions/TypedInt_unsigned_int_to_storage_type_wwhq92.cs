using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class TypedInt_unsigned_int_to_storage_type_wwhq92
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE8TypedIntIjE15to_storage_typeEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::TypedInt<unsigned int>::to_storage_type() const")]
	[CleanName("TypedInt_unsigned_int_to_storage_type")]
	public unsafe static short Invoke(void* @this)
	{
		return unchecked((short)((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0);
	}
}
