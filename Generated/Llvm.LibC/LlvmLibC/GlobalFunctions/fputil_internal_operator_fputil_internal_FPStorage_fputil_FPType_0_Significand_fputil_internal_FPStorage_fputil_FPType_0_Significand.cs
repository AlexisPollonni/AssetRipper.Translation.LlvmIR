using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internalorENS1_9FPStorageILNS0_6FPTypeE0EE11SignificandES5_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator|(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::Significand)")]
internal static partial class fputil_internal_operator_fputil_internal_FPStorage_fputil_FPType_0_Significand_fputil_internal_FPStorage_fputil_FPType_0_Significand
{
	public unsafe static short Invoke([MangledName("a.coerce")] short a, [MangledName("b.coerce")] short b)
	{
		fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h2 = default(fputil_internal_FPRepSem_i7nz4h);
		fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h3 = default(fputil_internal_FPRepSem_i7nz4h);
		fputil_internal_FPRepSem_i7nz4h fputil_internal_FPRepSem_i7nz4h4 = default(fputil_internal_FPRepSem_i7nz4h);
		fputil_internal_FPRepSem_i7nz4h3.FPStorage.field_0 = a;
		fputil_internal_FPRepSem_i7nz4h4.FPStorage.field_0 = b;
		fputil_internal_FPStorage_fputil_FPType_0_Significand_Significand_unsigned_short.Invoke(&fputil_internal_FPRepSem_i7nz4h2, unchecked((short)((ushort)fputil_internal_FPStorage_fputil_FPType_0_TypedInt_unsigned_short_to_storage_type_const.Invoke(&fputil_internal_FPRepSem_i7nz4h3) | (ushort)fputil_internal_FPStorage_fputil_FPType_0_TypedInt_unsigned_short_to_storage_type_const.Invoke(&fputil_internal_FPRepSem_i7nz4h4))));
		return fputil_internal_FPRepSem_i7nz4h2.FPStorage.field_0;
	}
}
