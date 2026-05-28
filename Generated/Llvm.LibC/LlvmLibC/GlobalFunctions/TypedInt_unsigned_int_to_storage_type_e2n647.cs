using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class TypedInt_unsigned_int_to_storage_type_e2n647
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE8TypedIntIjE15to_storage_typeEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::TypedInt<unsigned int>::to_storage_type() const")]
	[CleanName("TypedInt_unsigned_int_to_storage_type")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("this")] void* This)
	{
		unchecked
		{
			Int128 @int = (Int128)(UInt128)(uint)((Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0;
			return *(Struct_fiz2nb*)(&@int);
		}
	}
}
