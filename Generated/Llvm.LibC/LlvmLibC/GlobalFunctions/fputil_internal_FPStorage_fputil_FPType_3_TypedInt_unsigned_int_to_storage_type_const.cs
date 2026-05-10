using System;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE8TypedIntIjE15to_storage_typeEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::TypedInt<unsigned int>::to_storage_type() const")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_3_TypedInt_unsigned_int_to_storage_type_const
{
	public unsafe static Struct_fiz2nb Invoke(void* @this)
	{
		unchecked
		{
			Int128 @int = (Int128)(UInt128)(uint)((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0;
			return *(Struct_fiz2nb*)(&@int);
		}
	}
}
