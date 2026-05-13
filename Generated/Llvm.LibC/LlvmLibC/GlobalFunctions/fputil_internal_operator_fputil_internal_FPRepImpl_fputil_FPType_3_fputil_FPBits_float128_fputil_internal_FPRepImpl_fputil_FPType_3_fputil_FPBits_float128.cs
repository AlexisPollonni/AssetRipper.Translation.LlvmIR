using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internaleqENS1_9FPRepImplILNS0_6FPTypeE3ENS0_6FPBitsIgEEEES6_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::operator==(__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)3, __llvm_libc_20_1_2_::fputil::FPBits<__float128>>, __llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)3, __llvm_libc_20_1_2_::fputil::FPBits<__float128>>)")]
internal static partial class fputil_internal_operator_fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128
{
	public unsafe static bool Invoke([MangledName("a.coerce0")] long a, [MangledName("a.coerce1")] long b, [MangledName("b.coerce0")] long b_coerce0, [MangledName("b.coerce1")] long b_coerce1)
	{
		fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud10 = default(fputil_internal_FPRepImpl_jrxud9);
		fputil_internal_FPRepImpl_jrxud9 fputil_internal_FPRepImpl_jrxud11 = default(fputil_internal_FPRepImpl_jrxud9);
		Int128 @int = default(Int128);
		Int128 y = default(Int128);
		unchecked
		{
			*(long*)(&fputil_internal_FPRepImpl_jrxud10) = a;
			((long*)(&fputil_internal_FPRepImpl_jrxud10))[1] = b;
			*(long*)(&fputil_internal_FPRepImpl_jrxud11) = b_coerce0;
			((long*)(&fputil_internal_FPRepImpl_jrxud11))[1] = b_coerce1;
			Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval_const.Invoke(&fputil_internal_FPRepImpl_jrxud10);
			Int128* num = &@int;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num = struct_fiz2nb2.field_0;
			byte* num2 = (byte*)(&@int) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num2 = struct_fiz2nb3.field_1;
			Int128 x = @int;
			Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_uintval_const.Invoke(&fputil_internal_FPRepImpl_jrxud11);
			Int128* num3 = &y;
			Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
			*(long*)num3 = struct_fiz2nb5.field_0;
			byte* num4 = (byte*)(&y) + 8u;
			Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
			*(long*)num4 = struct_fiz2nb6.field_1;
			return NumericHelper.IntCmpEq(x, y);
		}
	}
}
