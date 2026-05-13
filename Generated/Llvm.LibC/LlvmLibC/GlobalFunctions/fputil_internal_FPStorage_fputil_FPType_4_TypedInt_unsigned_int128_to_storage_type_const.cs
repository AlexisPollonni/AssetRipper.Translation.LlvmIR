using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE4EE8TypedIntIoE15to_storage_typeEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::TypedInt<unsigned __int128>::to_storage_type() const")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_4_TypedInt_unsigned_int128_to_storage_type_const
{
	public unsafe static Struct_fiz2nb Invoke(void* @this)
	{
		unchecked
		{
			Int128 field_ = ((fputil_internal_FPStorage_w3h7gw*)@this)->field_0;
			return *(Struct_fiz2nb*)(&field_);
		}
	}
}
