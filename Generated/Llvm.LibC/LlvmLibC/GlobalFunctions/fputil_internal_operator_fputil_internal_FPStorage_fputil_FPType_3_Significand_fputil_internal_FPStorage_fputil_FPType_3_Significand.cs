using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internalorENS1_9FPStorageILNS0_6FPTypeE3EE11SignificandES5_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator|(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::Significand, __llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::Significand)")]
internal static partial class fputil_internal_operator_fputil_internal_FPStorage_fputil_FPType_3_Significand_fputil_internal_FPStorage_fputil_FPType_3_Significand
{
	public unsafe static Struct_fiz2nb Invoke([MangledName("a.coerce0")] long a, [MangledName("a.coerce1")] long b, [MangledName("b.coerce0")] long b_coerce0, [MangledName("b.coerce1")] long b_coerce1)
	{
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua2 = default(fputil_internal_FPRepSem_f94eua);
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua3 = default(fputil_internal_FPRepSem_f94eua);
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua4 = default(fputil_internal_FPRepSem_f94eua);
		Int128 @int = default(Int128);
		Int128 y = default(Int128);
		unchecked
		{
			*(long*)(&fputil_internal_FPRepSem_f94eua3) = a;
			((long*)(&fputil_internal_FPRepSem_f94eua3))[1] = b;
			*(long*)(&fputil_internal_FPRepSem_f94eua4) = b_coerce0;
			((long*)(&fputil_internal_FPRepSem_f94eua4))[1] = b_coerce1;
			Struct_fiz2nb struct_fiz2nb = fputil_internal_FPStorage_fputil_FPType_3_TypedInt_unsigned_int128_to_storage_type_const.Invoke(&fputil_internal_FPRepSem_f94eua3);
			Int128* num = &@int;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 x = @int;
			Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPStorage_fputil_FPType_3_TypedInt_unsigned_int128_to_storage_type_const.Invoke(&fputil_internal_FPRepSem_f94eua4);
			Int128* num3 = &y;
			Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
			*(long*)num3 = struct_fiz2nb5.field_0;
			byte* num4 = (byte*)(&y) + 8u;
			Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
			*(long*)num4 = struct_fiz2nb6.field_1;
			Int128 int2 = NumericHelper.BitwiseOr(x, y);
			fputil_internal_FPStorage_fputil_FPType_3_Significand_Significand_unsigned_int128.Invoke(&fputil_internal_FPRepSem_f94eua2, *(long*)(&int2), ((long*)(&int2))[1]);
			return *(Struct_fiz2nb*)(&fputil_internal_FPRepSem_f94eua2.FPStorage.field_0);
		}
	}
}
