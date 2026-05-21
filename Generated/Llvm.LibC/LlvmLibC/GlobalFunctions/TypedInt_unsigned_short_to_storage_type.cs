using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class TypedInt_unsigned_short_to_storage_type
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE8TypedIntItE15to_storage_typeEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::TypedInt<unsigned short>::to_storage_type() const")]
	public unsafe static short Invoke(void* @this)
	{
		return unchecked((fputil_internal_FPStorage_za9n4f*)@this)->field_0;
	}
}
