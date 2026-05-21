using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_BitwiseOr_sf5vh5
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internalorENS1_9FPStorageILNS0_6FPTypeE0EE11SignificandES5_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator|(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand)")]
	[CleanName("internal_BitwiseOr")]
	public unsafe static short Invoke([MangledName("a.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand")] short a, [MangledName("b.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand")] short b)
	{
		fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h2 = default(fputil_internal_FPRepSem_i7nz4h);
		fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h3 = default(fputil_internal_FPRepSem_i7nz4h);
		fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h4 = default(fputil_internal_FPRepSem_i7nz4h);
		fputil_internal_FPRepSem_i7nz4h3.FPStorage.field_0 = a;
		fputil_internal_FPRepSem_i7nz4h4.FPStorage.field_0 = b;
		Significand_Constructor_n44wpn.Invoke(&fputil_internal_FPRepSem_i7nz4h2, unchecked((short)((ushort)TypedInt_unsigned_short_to_storage_type.Invoke(&fputil_internal_FPRepSem_i7nz4h3) | (ushort)TypedInt_unsigned_short_to_storage_type.Invoke(&fputil_internal_FPRepSem_i7nz4h4))));
		return fputil_internal_FPRepSem_i7nz4h2.FPStorage.field_0;
	}
}
