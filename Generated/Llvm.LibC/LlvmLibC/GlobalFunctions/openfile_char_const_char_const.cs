using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Intrinsics.Unimplemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8openfileEPKcS1_")]
[DemangledName("__llvm_libc_20_1_2_::openfile(char const*, char const*)")]
internal static partial class openfile_char_const_char_const
{
	public unsafe static Struct_yx4nca Invoke(void* path, void* mode)
	{
		cpp_optional_char_OptionalStorage cpp_optional_char_OptionalStorage2 = default(cpp_optional_char_OptionalStorage);
		int num = 0;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		long num2 = 0L;
		long num3 = 0L;
		int num4 = 0;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt3 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		void* buffer = null;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt4 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		void* ptr = null;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt5 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = File_mode_flags_char_const.Invoke(mode);
		unchecked
		{
			if (num == 0)
			{
				cpp_unexpected_int_unexpected_int.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2, 22);
				cpp_expected_File_int_expected_cpp_unexpected_int.Invoke(&cpp_optional_char_OptionalStorage2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = 0L;
				if ((num & 4) != 0)
				{
					num2 = 1088L;
					num2 = (((num & 8) == 0) ? (num2 | 1L) : (num2 | 2L));
				}
				else if ((num & 2) != 0)
				{
					num2 = 576L;
					num2 = (((num & 8) == 0) ? (num2 | 1L) : (num2 | 2L));
				}
				else
				{
					num2 = (((num & 8) == 0) ? (num2 | 0L) : (num2 | 2L));
				}
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = 438L;
				llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = int_syscall_impl_int_char_const_long_long_long_char_const_long_long.Invoke(2L, path, num2, 438L);
				if (num4 < 0)
				{
					cpp_unexpected_int_unexpected_int.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt3, checked(-num4));
					cpp_expected_File_int_expected_cpp_unexpected_int.Invoke(&cpp_optional_char_OptionalStorage2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt3.field_0);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &buffer);
					buffer = (void*)12297829382473034410uL;
					llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
					*(sbyte*)(&anon_izyfb8) = -86;
					AllocChecker_AllocChecker.Invoke(&anon_izyfb8);
					buffer = operator_new_unsigned_long_AllocChecker_y8sjvz.Invoke(1024L, &anon_izyfb8);
					int num5;
					if (!AllocChecker_operator_bool_const.Invoke(&anon_izyfb8))
					{
						cpp_unexpected_int_unexpected_int.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt4, 12);
						cpp_expected_File_int_expected_cpp_unexpected_int.Invoke(&cpp_optional_char_OptionalStorage2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt4.field_0);
						num5 = 1;
					}
					else
					{
						num5 = 0;
					}
					llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
					switch (num5)
					{
					case 0:
					{
						llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb9);
						*(sbyte*)(&anon_izyfb9) = -86;
						AllocChecker_AllocChecker.Invoke(&anon_izyfb9);
						llvm_lifetime_start_p0.Invoke(8L, &ptr);
						void* ptr2 = operator_new_unsigned_long_AllocChecker_x3ybds.Invoke(128L, &anon_izyfb9);
						nint num6;
						if (ptr2 == null)
						{
							num6 = 0;
						}
						else
						{
							LinuxFile_LinuxFile_int_unsigned_char_unsigned_long_int_bool_unsigned_int.Invoke(ptr2, num4, buffer, 1024L, 0, owned: true, num);
							num6 = (nint)ptr2;
						}
						ptr = (void*)num6;
						if (!AllocChecker_operator_bool_const.Invoke(&anon_izyfb9))
						{
							cpp_unexpected_int_unexpected_int.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt5, 12);
							cpp_expected_File_int_expected_cpp_unexpected_int.Invoke(&cpp_optional_char_OptionalStorage2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt5.field_0);
						}
						else
						{
							cpp_expected_File_int_expected_File.Invoke(&cpp_optional_char_OptionalStorage2, ptr);
						}
						llvm_lifetime_end_p0.Invoke(8L, &ptr);
						llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb9);
						break;
					}
					}
					llvm_lifetime_end_p0.Invoke(8L, &buffer);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num4);
				llvm_lifetime_end_p0.Invoke(8L, &num3);
				llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return *(Struct_yx4nca*)(&cpp_optional_char_OptionalStorage2);
		}
	}
}
