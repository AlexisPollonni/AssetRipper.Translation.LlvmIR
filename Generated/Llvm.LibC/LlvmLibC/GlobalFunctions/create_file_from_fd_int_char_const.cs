using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Intrinsics.Unimplemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_19create_file_from_fdEiPKc")]
[DemangledName("__llvm_libc_20_1_2_::create_file_from_fd(int, char const*)")]
internal static partial class create_file_from_fd_int_char_const
{
	public unsafe static Struct_yx4nca Invoke(int fd, void* mode)
	{
		cpp_optional_char_OptionalStorage cpp_optional_char_OptionalStorage2 = default(cpp_optional_char_OptionalStorage);
		int num = 0;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		int num2 = 0;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt3 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt4 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		sbyte b = 0;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt5 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		void* buffer = null;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt6 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		void* ptr = null;
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt7 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		cpp_optional_int_OptionalStorage cpp_optional_int_OptionalStorage2 = default(cpp_optional_int_OptionalStorage);
		fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt8 = default(fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = File_mode_flags_char_const.Invoke(mode);
		if (num == 0)
		{
			cpp_unexpected_int_unexpected_int.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2, 22);
			cpp_expected_LinuxFile_int_expected_cpp_unexpected_int.Invoke(&cpp_optional_char_OptionalStorage2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt2.field_0);
			goto IL_042a;
		}
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = internal_fcntl_int_int_void.Invoke(fd, 3, null);
		unchecked
		{
			if (num2 == -1)
			{
				cpp_unexpected_int_unexpected_int.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt3, 9);
				cpp_expected_LinuxFile_int_expected_cpp_unexpected_int.Invoke(&cpp_optional_char_OptionalStorage2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt3.field_0);
			}
			else
			{
				if (((num2 & 3) != 0 || (num & 1) != 0) && ((num2 & 3) != 1 || (num & 2) != 0))
				{
					llvm_lifetime_start_p0.Invoke(1L, &b);
					b = 0;
					if ((num & 4) != 0 && (num2 & 0x400) == 0)
					{
						b = 1;
						if (internal_fcntl_int_int_void.Invoke(fd, 4, (void*)(num2 | 0x400)) == -1)
						{
							cpp_unexpected_int_unexpected_int.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt5, 9);
							cpp_expected_LinuxFile_int_expected_cpp_unexpected_int.Invoke(&cpp_optional_char_OptionalStorage2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt5.field_0);
							goto IL_0406;
						}
					}
					llvm_lifetime_start_p0.Invoke(8L, &buffer);
					buffer = (void*)12297829382473034410uL;
					llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
					*(sbyte*)(&anon_izyfb8) = -86;
					AllocChecker_AllocChecker.Invoke(&anon_izyfb8);
					buffer = operator_new_unsigned_long_AllocChecker_y8sjvz.Invoke(1024L, &anon_izyfb8);
					int num3;
					if (!AllocChecker_operator_bool_const.Invoke(&anon_izyfb8))
					{
						cpp_unexpected_int_unexpected_int.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt6, 12);
						cpp_expected_LinuxFile_int_expected_cpp_unexpected_int.Invoke(&cpp_optional_char_OptionalStorage2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt6.field_0);
						num3 = 1;
					}
					else
					{
						num3 = 0;
					}
					llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
					switch (num3)
					{
					case 0:
						{
							llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb9);
							*(sbyte*)(&anon_izyfb9) = -86;
							AllocChecker_AllocChecker.Invoke(&anon_izyfb9);
							llvm_lifetime_start_p0.Invoke(8L, &ptr);
							void* ptr2 = operator_new_unsigned_long_AllocChecker_x3ybds.Invoke(128L, &anon_izyfb9);
							nint num4;
							if (ptr2 == null)
							{
								num4 = 0;
							}
							else
							{
								LinuxFile_LinuxFile_int_unsigned_char_unsigned_long_int_bool_unsigned_int.Invoke((LinuxFile*)ptr2, fd, buffer, 1024L, 0, owned: true, num);
								num4 = (nint)ptr2;
							}
							ptr = (void*)num4;
							if (!AllocChecker_operator_bool_const.Invoke(&anon_izyfb9))
							{
								cpp_unexpected_int_unexpected_int.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt7, 12);
								cpp_expected_LinuxFile_int_expected_cpp_unexpected_int.Invoke(&cpp_optional_char_OptionalStorage2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt7.field_0);
							}
							else
							{
								if ((b & 1) == 1)
								{
									llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_int_OptionalStorage2);
									*(int*)(&cpp_optional_int_OptionalStorage2) = -1431655766;
									((sbyte*)(&cpp_optional_int_OptionalStorage2))[4] = -86;
									sbyte* ptr3 = (sbyte*)(&cpp_optional_int_OptionalStorage2) + 5;
									*ptr3 = -86;
									ptr3[1] = -86;
									ptr3[2] = -86;
									*(InlineArray5_Byte*)(&cpp_optional_int_OptionalStorage2) = NumericHelper.TruncOrZextToBytes<long, InlineArray5_Byte>(File_seek_long_int.Invoke(ptr, 0L, 2));
									if (!cpp_expected_int_int_has_value_const.Invoke(&cpp_optional_int_OptionalStorage2))
									{
										free.Invoke(ptr);
										cpp_unexpected_int_unexpected_int.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt8, *(int*)cpp_expected_int_int_error.Invoke(&cpp_optional_int_OptionalStorage2));
										cpp_expected_LinuxFile_int_expected_cpp_unexpected_int.Invoke(&cpp_optional_char_OptionalStorage2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt8.field_0);
										num3 = 1;
									}
									else
									{
										num3 = 0;
									}
									llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_int_OptionalStorage2);
									switch (num3)
									{
									case 0:
										break;
									default:
										goto IL_03d2;
									}
								}
								cpp_expected_LinuxFile_int_expected_LinuxFile.Invoke(&cpp_optional_char_OptionalStorage2, (LinuxFile*)ptr);
							}
							goto IL_03d2;
						}
						IL_03d2:
						llvm_lifetime_end_p0.Invoke(8L, &ptr);
						llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb9);
						break;
					}
					llvm_lifetime_end_p0.Invoke(8L, &buffer);
					goto IL_0406;
				}
				cpp_unexpected_int_unexpected_int.Invoke(&fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt4, 22);
				cpp_expected_LinuxFile_int_expected_cpp_unexpected_int.Invoke(&cpp_optional_char_OptionalStorage2, fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt4.field_0);
			}
			goto IL_0418;
		}
		IL_0418:
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		goto IL_042a;
		IL_0406:
		llvm_lifetime_end_p0.Invoke(1L, &b);
		goto IL_0418;
		IL_042a:
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return *unchecked((Struct_yx4nca*)(&cpp_optional_char_OptionalStorage2));
	}
}
