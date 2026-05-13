using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internalrsENS1_9FPStorageILNS0_6FPTypeE3EE11SignificandEi")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator>>(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::Significand, int)")]
internal static partial class fputil_internal_operator_fputil_internal_FPStorage_fputil_FPType_3_Significand_int
{
	public unsafe static Struct_fiz2nb Invoke([MangledName("a.coerce0")] long a, [MangledName("a.coerce1")][CleanName("shift")] long shift_eq4gfg, [MangledName("shift")][CleanName("shift")] int shift_s8dkmd)
	{
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua2 = default(fputil_internal_FPRepSem_f94eua);
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua3 = default(fputil_internal_FPRepSem_f94eua);
		Int128 x = default(Int128);
		unchecked
		{
			*(long*)(&fputil_internal_FPRepSem_f94eua3) = a;
			((long*)(&fputil_internal_FPRepSem_f94eua3))[1] = shift_eq4gfg;
			Struct_fiz2nb struct_fiz2nb = fputil_internal_FPStorage_fputil_FPType_3_TypedInt_unsigned_int128_to_storage_type_const.Invoke(&fputil_internal_FPRepSem_f94eua3);
			Int128* num = &x;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&x) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 @int = NumericHelper.ShiftRightLogical(x, (Int128)(UInt128)(uint)shift_s8dkmd);
			fputil_internal_FPStorage_fputil_FPType_3_Significand_Significand_unsigned_int128.Invoke(&fputil_internal_FPRepSem_f94eua2, *(long*)(&@int), ((long*)(&@int))[1]);
			return *(Struct_fiz2nb*)(&fputil_internal_FPRepSem_f94eua2.FPStorage.field_0);
		}
	}
}
