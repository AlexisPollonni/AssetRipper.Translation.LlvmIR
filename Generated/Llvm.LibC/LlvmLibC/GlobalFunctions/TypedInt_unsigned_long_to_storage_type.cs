using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class TypedInt_unsigned_long_to_storage_type
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE8TypedIntImE15to_storage_typeEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::TypedInt<unsigned long>::to_storage_type() const")]
	public unsafe static long Invoke([MangledName("this")] void* This)
	{
		return unchecked((Llvm_libc_20_1_2_fputil_internal_FPStorage_v3nexn*)This)->Val;
	}
}
