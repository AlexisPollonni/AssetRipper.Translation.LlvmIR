using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_BitwiseOr_sf5vh5
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internalorENS1_9FPStorageILNS0_6FPTypeE0EE11SignificandES5_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator|(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand)")]
	[CleanName("Internal_BitwiseOr")]
	public unsafe static short Invoke([MangledName("a.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand")] short A, [MangledName("b.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand")] short B)
	{
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h);
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h2 = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h);
		Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h3 = default(Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h);
		llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h2.FPStorage.field_0 = A;
		llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h3.FPStorage.field_0 = B;
		Significand_Constructor_n44wpn.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h, unchecked((short)((ushort)TypedInt_unsigned_short_to_storage_type.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h2) | (ushort)TypedInt_unsigned_short_to_storage_type.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h3))));
		return llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h.FPStorage.field_0;
	}
}
