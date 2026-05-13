using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE4EE6encodeENS4_11SignificandE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::encode(__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::Significand)")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_4_encode_fputil_internal_FPStorage_fputil_FPType_4_Significand
{
	public unsafe static Struct_fiz2nb Invoke([MangledName("value.coerce0")] long value, [MangledName("value.coerce1")] long value_coerce1)
	{
		fputil_internal_FPRepSem_f94eua fputil_internal_FPRepSem_f94eua2 = default(fputil_internal_FPRepSem_f94eua);
		Int128 x = default(Int128);
		unchecked
		{
			*(long*)(&fputil_internal_FPRepSem_f94eua2) = value;
			((long*)(&fputil_internal_FPRepSem_f94eua2))[1] = value_coerce1;
			Struct_fiz2nb struct_fiz2nb = fputil_internal_FPStorage_fputil_FPType_4_TypedInt_unsigned_int128_to_storage_type_const.Invoke(&fputil_internal_FPRepSem_f94eua2);
			Int128* num = &x;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&x) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 @int = NumericHelper.BitwiseAnd(x, -1L);
			return *(Struct_fiz2nb*)(&@int);
		}
	}
}
